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
    public partial class TestingTasksModulesToTestsBind : Form
    {
        public TestingTasksModulesToTestsBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        int id;

        private void TestingTasksModulesToTestsBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet74.B05_view_tt_modules_to_tests". При необходимости она может быть перемещена или удалена.
            this.b05_view_tt_modules_to_testsTableAdapter.Fill(this.bd_kidsDataSet74.B05_view_tt_modules_to_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet73.T03_view_tt_modules". При необходимости она может быть перемещена или удалена.
            this.t03_view_tt_modulesTableAdapter1.Fill(this.bd_kidsDataSet73.T03_view_tt_modules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet72.T03_view_tt_modules". При необходимости она может быть перемещена или удалена.
            this.t03_view_tt_modulesTableAdapter.Fill(this.bd_kidsDataSet72.T03_view_tt_modules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet71.T02_tests". При необходимости она может быть перемещена или удалена.
            this.t02_testsTableAdapter.Fill(this.bd_kidsDataSet71.T02_tests);
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label2, "название модуля ТЗ (его сквозной порядковый номер)");
        }

        private void B05_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(B05.CurrentRow.Cells[0].Value.ToString());
        }

        private void updateB05()
        {
            try
            {
                int code_test = int.Parse(B05_list_tests.SelectedValue.ToString());

                var data = bd.B05_view_tt_modules_to_tests.Select(x => new { x.id, x.id_test, x.serial_number_module, x.name_task, x.note }).Where(x => x.id_test == code_test);
                B05.DataSource = data.ToList();
            }
            catch (Exception ee) { }
        }

        private void B05_list_tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateB05();
        }

        private void B05addButton_Click(object sender, EventArgs e)
        {
            int id_test = int.Parse(B05_list_tests.SelectedValue.ToString());
            int id_module = int.Parse(B05_list_modules.SelectedValue.ToString());

            if (B05_serial_number_module.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new B05_testing_task_modules_to_tests()
                {
                    id_test = id_test,
                    id_module = id_module,
                    serial_number_module = int.Parse(B05_serial_number_module.Text),
                    note = B05_note.Text == "" ? " " : B05_note.Text
                };
                bd.B05_testing_task_modules_to_tests.Add(person);
                bd.SaveChanges();

            }

            B05_serial_number_module.Clear();
            B05_note.Clear();
            updateB05();
        }

        private void B05changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.B05_testing_task_modules_to_tests.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            row.serial_number_module = int.Parse(B05.CurrentRow.Cells[2].Value.ToString());
            row.note = B05.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();
        }

        private void B05deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.B05_testing_task_modules_to_tests.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            bd.B05_testing_task_modules_to_tests.Remove(row);
            bd.SaveChanges();

            updateB05();
        }
    }
}
