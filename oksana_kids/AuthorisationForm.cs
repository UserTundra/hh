using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
            
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        public static long peopleID;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer();
            
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void timer()
        {
            Timer FormTimer = new Timer();
            FormTimer.Interval = 1000;
            FormTimer.Start();

            FormTimer.Tick += new EventHandler(FormTimer_Tick);
        }

        private string logIn()
        {
            string login = tlogin.Text;
            string password = tpassword.Text;

            //string login = "anpilova.k"; // VOT EOT DLYATESTOV!1111
            //string password = "anpilova.k";

            //string login = "admin";
            //var password = "admin";

            string who = "";
            DateTime localDate = DateTime.Now;

            try
            {
                if (login == "" || password == "")
                {
                    MessageBox.Show("Заполните поля для входа");
                    
                }

                else
                {                    
                    var query = (from a in bd.T01_personalities
                                join b in bd.R01_people_category on a.code_category equals b.code_category
                                where a.login.Equals(login) && a.password.Equals(password)
                                select new
                                {
                                    id_person = a.id_person,
                                    name = a.surname + " " + a.name.Substring(0, 1) + ". " + a.patronymic.Substring(0, 1) + ".",
                                    category = b.name_category,
                                }).ToList();
                    
                    if (query.Any())
                    {
                        foreach (var item in query)
                        {
                            who += item.category;
                            AuthorisationForm.peopleID = item.id_person;
                            MessageBox.Show(item.category + " : " + item.name + "\r\nДата авторизации : " + localDate.ToString());
                         }

                        if (who == "ученик")
                        {
                            PupilSelectionWindow f = new PupilSelectionWindow();
                            f.Show();
                        }
                        else
                        {
                            TeacherSelectionMindow f = new TeacherSelectionMindow();
                            f.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        tlogin.Clear();
                        tpassword.Clear();
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }

                
            }
            catch(Exception e)
            {
                tlogin.Clear();
                tpassword.Clear();
                MessageBox.Show("Ошибка");
                MessageBox.Show(e.Message);
            }

            return who;
            
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            logIn();
        }

        
    }
}
