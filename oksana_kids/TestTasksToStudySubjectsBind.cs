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
    public partial class TestTasksToStudySubjectsBind : Form
    {
        public TestTasksToStudySubjectsBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        int id;

        private void TestTasksToStudySubjectsBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet35.T04_view_testing_tasks". При необходимости она может быть перемещена или удалена.
            this.t04_view_testing_tasksTableAdapter.Fill(this.bd_kidsDataSet35.T04_view_testing_tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet34.B04_bind_view". При необходимости она может быть перемещена или удалена.
            this.b04_bind_viewTableAdapter.Fill(this.bd_kidsDataSet34.B04_bind_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet33.R09_study_subjects". При необходимости она может быть перемещена или удалена.
            this.r09_study_subjectsTableAdapter.Fill(this.bd_kidsDataSet33.R09_study_subjects);
            updateT04();
            B04_list_subjects.SelectedItem = "1";
            updateB04();

        }

        private void updateT04()
        {           
            var data = bd.T04_view_testing_tasks.Select(x => new { x.id_task, x.name_task, x.date_create, x.name_type });
            B04.DataSource = data.ToList();            
        }

        private void updateB04()
        {
            try
            {
                int code_subject2 = int.Parse(B04_list_subjects.SelectedValue.ToString());

                var data = bd.B04_bind_view.Select(x => new { x.id, x.code_subject, x.name_task, x.equvivalent_perc, x.note }).Where(x => x.code_subject == code_subject2);
                B04.DataSource = data.ToList();
            }
            catch (Exception ee) { }
        }

        private void B04addButton_Click(object sender, EventArgs e)
        {
            int id_task = int.Parse(T04.CurrentRow.Cells[0].Value.ToString());
            int code_subject = int.Parse(B04_list_subjects.SelectedValue.ToString());

            if (B04_equvivalent_perc.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new B04_test_tasks_to_study_subjects()
                {
                    id_task = id_task,
                    code_subject = code_subject,
                    equvivalent_perc = int.Parse(B04_equvivalent_perc.Text),
                    note = B04_note.Text == "" ? " " : B04_note.Text
                };
                bd.B04_test_tasks_to_study_subjects.Add(person);
                bd.SaveChanges();

            }
            B04_equvivalent_perc.Clear();
            B04_note.Clear();
            updateB04();
        }

        private void B04_list_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateB04();
        }

        private void B04changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.B04_test_tasks_to_study_subjects.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            row.equvivalent_perc = int.Parse(B04.CurrentRow.Cells[3].Value.ToString());
            row.note = B04.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();
        }

        private void B04_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(B04.CurrentRow.Cells[0].Value.ToString());
        }

        private void B04deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.B04_test_tasks_to_study_subjects.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            bd.B04_test_tasks_to_study_subjects.Remove(row);
            bd.SaveChanges();

            updateB04();
        }
    }
}
