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
    public partial class AdaptiveTestConstructor : Form
    {
        public int try_number;
        public int change_number;
        public string name = "";

        public long testID;

        public T02_tests test;
        private bd_kidsEntities1 connect = new bd_kidsEntities1();


        public AdaptiveTestConstructor(string testName, long testID)
        {
            try { 
                name = testName;
                InitializeComponent();
                this.testID = testID;
                this.test = connect.T02_tests.Where(x => x.id_test == testID).FirstOrDefault();
                if (test == null)
                    this.Hide();
                this.max_duration_testing.Text = test.max_passing_duration_sec.ToString();
                this.max_not_done_TT.Text = test.max_count_TT_not_done_full_try.ToString();
                this.max_TT_with_high_time_limit.Text = test.max_count_TT_bcause_time_limit.ToString();
            }catch(Exception ee)
            {
                MessageBox.Show("Возникла ошибка загрузки данных, выберите тест");
            }
        }


        private void AdaptiveTestConstructor_Load(object sender, EventArgs e)
        {
            selectedTest.Text = name;
            
            
        }

        private void change_answer_numbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaptiveTestConstructorGo_Click(object sender, EventArgs e)
        {
            try { 
                test.max_count_TT_bcause_time_limit = this.max_TT_with_high_time_limit.Text == "" ? test.max_count_TT_bcause_time_limit : long.Parse(this.max_TT_with_high_time_limit.Text);
                test.max_count_TT_not_done_full_try = this.max_not_done_TT.Text == "" ? test.max_count_TT_not_done_full_try : long.Parse(this.max_not_done_TT.Text);
                test.max_passing_duration_sec = this.max_duration_testing.Text == "" ? test.max_passing_duration_sec : long.Parse(this.max_duration_testing.Text);
            }catch(Exception ee)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
