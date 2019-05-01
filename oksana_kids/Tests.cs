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
    public partial class Tests : Form
    {
        public int tabIndex;
        public string testName = "";
        public string taskName = "";

        List<string> fio = new List<string>();
        Dictionary<int, string> fio_dict = new Dictionary<int, string>();

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        public Tests(int index)
        {
            tabIndex = index;
            InitializeComponent();


        }

        public Tests() {

        }

        private void Tests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet_TESTING_TASKS.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.
            this.t04_view_testing_tasksTableAdapter3.Fill(this.bd_kidsDataSet_TESTING_TASKS.T04_view_testing_tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSetFOR_TESTS.T02_view_tests". При необходимости она может быть перемещена или удалена.
            this.t02_view_testsTableAdapter2.Fill(this.bd_kidsDataSetFOR_TESTS.T02_view_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet9.T02_view_tests". При необходимости она может быть перемещена или удалена.

            //this.t02_view_testsTableAdapter1.Fill(this.bd_kidsDataSet9.T02_view_tests);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet8.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.

            //this.t04_view_testing_tasksTableAdapter1.Fill(this.bd_kidsDataSet8.T04_view_testing_tasks);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet7.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.

            //this.t04_view_testing_tasksTableAdapter.Fill(this.bd_kidsDataSet7.T04_view_testing_tasks);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet5.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter.Fill(this.bd_kidsDataSet5.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet4.T01_personalities". При необходимости она может быть перемещена или удалена.
            this.t01_personalitiesTableAdapter.Fill(this.bd_kidsDataSet4.T01_personalities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet3.T02_view_tests". При необходимости она может быть перемещена или удалена.

            //this.t02_view_testsTableAdapter.Fill(this.bd_kidsDataSet3.T02_view_tests);

            tabControl1.SelectTab(tabIndex);

            test_construct_button.Enabled = false;



        }

        private void test_construct_button_Click(object sender, EventArgs e)
        {
            AdaptiveTestConstructor a = new AdaptiveTestConstructor(testName);
            a.Show();
        }
        
        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string selectedRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int testID = int.Parse(selectedRow);

            var linq = from i in bd.T02_tests
                       where i.id_test == testID
                       select new
                       {
                           name = i.name_test
                       };

            foreach (var item in linq)
            {
                testName = item.name;
            }

            test_construct_button.Enabled = true;
        }

        private void TT_constructor_button_Click(object sender, EventArgs e)
        {
            AdaptiveTTConstructor tt = new AdaptiveTTConstructor(taskName);
            tt.Show();
        }

        private void testAuthorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            string selectedRow = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            int TTID = int.Parse(selectedRow);

            var linq = from i in bd.T04_testing_tasks
                       where i.id_task == TTID
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

        private void T02addButton_Click(object sender, EventArgs e)
        {
            if (name_test.Text == "" || duration.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                //try
                //{
                bd_kidsDataSet.T02_testsRow row;
                row = bd_kidsDataSet.T02_tests.NewT02_testsRow();
                row.name_test = name_test.Text;
                row.name = name.Text;
                row.patronymic = patronymic.Text;

                //birth_date.Format = DateTimePickerFormat.Custom;
                //birth_date.CustomFormat = "dd.mm.yyyy";

                //row.date_birth = birth_date.Value; 
                row.date_birth = birth_date.Value.ToString("dd.MM.yyyy");

                row.gender = (long)gender.SelectedValue;
                row.code_category = (long)human_category.SelectedValue;
                row.id_org = (long)place_work_study.SelectedValue;
                if (human_category.SelectedValue.ToString() == "2")
                {
                    row.code_class = int.Parse(study_class.SelectedValue.ToString());
                }
                else
                {


                }
                row.login = login.Text;
                row.password = password.Text;
                row.date_updating = "null";


                row.note = note.Text == " " ? " " : note.Text;

                this.bd_kidsDataSet.T01_personalities.Rows.Add(row);
                this.t01_personalitiesTableAdapter.Update(this.bd_kidsDataSet.T01_personalities);

                gridViewPupils.DataSource = t011pupilsBindingSource1;
            }
    }
}
