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
    public partial class TestingAimsToTestsBind : Form
    {
        public TestingAimsToTestsBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        int id;

        private void TestingAimsToTestsBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet77.T02_tests". При необходимости она может быть перемещена или удалена.
            this.t02_testsTableAdapter.Fill(this.bd_kidsDataSet77.T02_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet76.R06_testing_aims". При необходимости она может быть перемещена или удалена.
            this.r06_testing_aimsTableAdapter.Fill(this.bd_kidsDataSet76.R06_testing_aims);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet75.B01_view_testing_aims_to_tests". При необходимости она может быть перемещена или удалена.
            this.b01_view_testing_aims_to_testsTableAdapter.Fill(this.bd_kidsDataSet75.B01_view_testing_aims_to_tests);

        }

        private void B01_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(B01.CurrentRow.Cells[0].Value.ToString());
        }

        private void updateB01()
        {
            try
            {
                int code_test = int.Parse(B01_list_tests.SelectedValue.ToString());

                var data = bd.B01_view_testing_aims_to_tests.Select(x => new { x.id, x.id_test, is_main_aim = x.is_main_aim == 1 ? "да" : "нет", x.name_aim, x.note }).Where(x => x.id_test == code_test);
                B01.DataSource = data.ToList();
            }
            catch (Exception ee) { }
        }

        private void B01_list_tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateB01();
        }

        private void B01addButton_Click(object sender, EventArgs e)
        {
            int id_test = int.Parse(B01_list_tests.SelectedValue.ToString());
            int id_aim = int.Parse(B01_list_aims.SelectedValue.ToString());

            if (!B01_is_main_aim_no.Checked || !B01_is_main_aim_yes.Checked)
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new B01_testing_aims_to_tests()
                {
                    id_test = id_test,
                    code_aim = id_aim,
                    is_main_aim = B01_is_main_aim_no.Checked == true ? 0 : 1,
                    note = B01_note.Text == "" ? " " : B01_note.Text
                };
                bd.B01_testing_aims_to_tests.Add(person);
                bd.SaveChanges();

            }

            B01_is_main_aim_no.Checked = false;
            B01_is_main_aim_yes.Checked = false;
            B01_note.Clear();
            updateB01();
        }

        private void B01changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.B01_testing_aims_to_tests.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            row.is_main_aim = B01.CurrentRow.Cells[3].Value.ToString() == "да" ? 1 : 0;
            row.note = B01.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();
        }
    }
}
