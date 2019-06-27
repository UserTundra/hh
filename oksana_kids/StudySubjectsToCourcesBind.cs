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
    public partial class StudySubjectsToCourcesBind : Form
    {
        public StudySubjectsToCourcesBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        int id;

        private void StudySubjectsToCourcesBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet30.B03_bind_view". При необходимости она может быть перемещена или удалена.
            this.b03_bind_viewTableAdapter.Fill(this.bd_kidsDataSet30.B03_bind_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet29.R08_study_courses". При необходимости она может быть перемещена или удалена.
            this.r08_study_coursesTableAdapter.Fill(this.bd_kidsDataSet29.R08_study_courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet28.R09_study_subjects". При необходимости она может быть перемещена или удалена.
            this.r09_study_subjectsTableAdapter.Fill(this.bd_kidsDataSet28.R09_study_subjects);

            updateB03();

            B03_list_course.SelectedValue = "1";

        }

        private void B03addButton_Click(object sender, EventArgs e)
        {
            int code_course = int.Parse(B03_list_course.SelectedValue.ToString());
            int code_subject = int.Parse(B03_list_subject.SelectedValue.ToString());

            if (B03_serial_number_subject.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new B03_study_subjects_to_courses()
                {
                    code_course = code_course,
                    code_subject = code_subject,
                    serial_number_subject = int.Parse(B03_serial_number_subject.Text),
                    note = B03_note.Text == "" ? " " : B03_note.Text
                };
                bd.B03_study_subjects_to_courses.Add(person);
                bd.SaveChanges();

            }

            B03_serial_number_subject.Clear();
            B03_note.Clear();
            updateB03();
        }

        private void updateB03()
        {
            try
            {
                int code_course = int.Parse(B03_list_course.SelectedValue.ToString());

                var data = bd.B03_bind_view.Select(x => new { x.id, x.code_course, x.serial_number_subject, x.name_subject, x.note }).Where(x => x.code_course == code_course);
                B03.DataSource = data.ToList();
            }
            catch(Exception ee) { }
        }
        
        private void B03_list_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateB03();
        }

        private void B03_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(B03.CurrentRow.Cells[0].Value.ToString());
        }

        private void B03changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.B03_study_subjects_to_courses.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            row.serial_number_subject = int.Parse(B03.CurrentRow.Cells[2].Value.ToString());
            row.note = B03.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();
        }

        private void B03deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.B03_study_subjects_to_courses.Where(x => x.id == id).FirstOrDefault();
            if (row == null) return;

            bd.B03_study_subjects_to_courses.Remove(row);
            bd.SaveChanges();

            updateB03();
        }
    }
}
