using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace oksana_kids
{
    public partial class Tests : Form
    {
        public int tabIndex;
        public string testName = "";
        public string taskName = "";

        public long testID = 0;

        List<string> fio = new List<string>();
        Dictionary<int, string> fio_dict = new Dictionary<int, string>();

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        private int id;
        public string filePath;

        public Tests(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        public Tests()
        {

        }

        private void Tests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet46.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.
            this.t04_view_testing_tasksTableAdapter1.Fill(this.bd_kidsDataSet46.T04_view_testing_tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet45.R03_testing_types". При необходимости она может быть перемещена или удалена.
            this.r03_testing_typesTableAdapter.Fill(this.bd_kidsDataSet45.R03_testing_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSetFOR_TESTS.T02_view_tests". При необходимости она может быть перемещена или удалена.
            this.t02_view_testsTableAdapter2.Fill(this.bd_kidsDataSetFOR_TESTS.T02_view_tests);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet5.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter.Fill(this.bd_kidsDataSet5.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet4.T01_personalities". При необходимости она может быть перемещена или удалена.
            this.t01_personalitiesTableAdapter.Fill(this.bd_kidsDataSet4.T01_personalities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet3.T02_view_tests". При необходимости она может быть перемещена или удалена.

            //this.t02_view_testsTableAdapter.Fill(this.bd_kidsDataSet3.T02_view_tests);

            tabControl1.SelectTab(tabIndex);

            test_construct_button.Enabled = false;
        }

        #region T02

        private void test_construct_button_Click(object sender, EventArgs e)
        {
            AdaptiveTestConstructor a = new AdaptiveTestConstructor(testName, testID);
            a.Show();
        }

        private void T02_Click(object sender, EventArgs e)
        {
            id = int.Parse(T02.CurrentRow.Cells[0].Value.ToString());

            var linq = from i in bd.T02_tests
                       where i.id_test == id
                       select new
                       {
                           name = i.name_test,
                           i.id_test
                       };

            foreach (var item in linq)
            {
                testName = item.name;
            }

            test_construct_button.Enabled = true;
        }

        private void updateT02()
        {
            var data = bd.T01_personalities.Join(
            bd.T02_tests,
            x => x.id_person,
            y => y.id_author,
            (p, w) => new {
                w.id_test,
                w.name_test,
                fio = p.surname + " " + p.name.Substring(0,1) + ". " + p.patronymic.Substring(0,1) + ".",
                w.date_create,
                w.date_correct,
                w.max_passing_duration_sec,
                w.note
            });

            T02.DataSource = data.ToList();
        }
        
        private void T02addButton_Click(object sender, EventArgs e)
        {
            if (name_test.Text == "" || duration.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new T02_tests()
                {
                    name_test = name_test.Text,
                    id_method_material = null,
                    id_author = int.Parse(testAuthorSelect.SelectedValue.ToString()),
                    date_create = datePicker_create.Value.ToString("dd.MM.yyyy"),
                    date_correct = null,
                    max_passing_duration_sec = int.Parse(duration.Text),
                    note = note.Text == "" ? " " : note.Text,
                    id_teach_material = null,
                    max_count_TT_bcause_time_limit = null,
                    max_count_TT_not_done_full_try = null
                };
                bd.T02_tests.Add(person);
                bd.SaveChanges();

            }
            name_test.Clear();
            duration.Clear();
            note.Clear();

            updateT02();
        }

        private void T02addMethodMaterial_Click(object sender, EventArgs e)
        {
            References r = new References(6);
            r.Show();
        }

        private void T02addTeachingMaterial_Click(object sender, EventArgs e)
        {
            Files f = new Files(2);
            f.Show();
        }

        private void T02changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.T02_tests.Where(x => x.id_test == id).FirstOrDefault();
            if (row == null) return;

            row.name_test = T02.CurrentRow.Cells[1].Value.ToString();
            row.date_create = T02.CurrentRow.Cells[3].Value.ToString();
            row.date_correct = DateTime.Now.ToString("dd.MM.yyy");
            row.max_passing_duration_sec = int.Parse(T02.CurrentRow.Cells[5].Value.ToString());
            row.note = T02.CurrentRow.Cells[6].Value.ToString();

            bd.SaveChanges();
            updateT02();
        }

        private void T02deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.T02_tests.Where(x => x.id_test == id).FirstOrDefault();
            if (row == null) return;

            bd.T02_tests.Remove(row);
            bd.SaveChanges();

            updateT02();
        }

        #endregion

        #region T04

        private void TT_constructor_button_Click(object sender, EventArgs e)
        {
            AdaptiveTTConstructor tt = new AdaptiveTTConstructor(taskName);
            tt.Show();
        }

        private void T04_Click(object sender, EventArgs e)
        {
            id = int.Parse(T04.CurrentRow.Cells[7].Value.ToString());

            var linq = from i in bd.T04_testing_tasks
                       where i.id_task == id
                       select new
                       {
                           name = i.name_task
                       };

            foreach (var item in linq)
            {
                taskName = item.name;
            }

            TT_constructor_button.Enabled = true;
        }

        private void updateT04()
        {

        }
        
        private void T04_file_location_Click(object sender, EventArgs e)
        {
            //Regex reg = new Regex(@"\\t{1}.*(.txt)");

            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                var match = Regex.Match(OPF.FileName, @"\\t{1}.*(.txt)").ToString();
                //MessageBox.Show(match.ToString());
                filePath += match.ToString();
                T04_show_file_location.Clear();
                T04_show_file_location.Text = filePath;
            }
        }
        
        private void T04addButton_Click(object sender, EventArgs e)
        {
            if (T04_name_task.Text == "" || filePath == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new T04_testing_tasks()
                {
                    name_task = T04_name_task.Text,
                    id_author = int.Parse(T04_id_author.SelectedValue.ToString()),
                    date_create = T04_date_create.Value.ToString("dd.MM.yyyy"),
                    date_correct = null,
                    code_type = int.Parse(T04_code_type.SelectedValue.ToString()),
                    note = note.Text == "" ? " " : note.Text,
                    file_location = filePath,
                };
                bd.T04_testing_tasks.Add(person);
                bd.SaveChanges();

            }
            T04_name_task.Clear();
            T04_note.Clear();

            //updateT04();
        }

        #endregion
    }
}