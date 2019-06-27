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
    public partial class StudyCourcesToPupilsClassesBind : Form
    {
        public StudyCourcesToPupilsClassesBind()
        {
            InitializeComponent();
        }

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        int id;
        int id2;

        private void StudyCourcesToPupilsClassesBind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet40.R08_study_courses". При необходимости она может быть перемещена или удалена.
            this.r08_study_coursesTableAdapter.Fill(this.bd_kidsDataSet40.R08_study_courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet39.B02_bind_view". При необходимости она может быть перемещена или удалена.
            this.b02_bind_viewTableAdapter1.Fill(this.bd_kidsDataSet39.B02_bind_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet36.R02_pupils_classes". При необходимости она может быть перемещена или удалена.
            this.r02_pupils_classesTableAdapter.Fill(this.bd_kidsDataSet36.R02_pupils_classes);

        }

        private void R02_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R02.CurrentRow.Cells[0].Value.ToString());
            updateB02();
        }

        private void updateB02()
        {
            try
            {
                var data = bd.B02_bind_view.Select(x => new { x.id, x.code_class, x.name_course, x.note}).Where(x => x.code_class == id);
                B02.DataSource = data.ToList();
            }
            catch (Exception ee) { }
        }

        private void B02addButton_Click(object sender, EventArgs e)
        {
            int code_course = int.Parse(R08_list_cources.SelectedValue.ToString());

            var person = new B02_study_courses_to_pupils_classes()
            {
                code_course = code_course,
                code_class = id,
                note = B02_note.Text == "" ? " " : B02_note.Text
            };
            bd.B02_study_courses_to_pupils_classes.Add(person);
            bd.SaveChanges();

            B02_note.Clear();
            updateB02();
        }

        private void B02changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.B02_study_courses_to_pupils_classes.Where(x => x.id == id2).FirstOrDefault();
            if (row == null) return;

            row.note = B02.CurrentRow.Cells[2].Value.ToString();

            bd.SaveChanges();
        }

        private void B02_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id2 = int.Parse(B02.CurrentRow.Cells[0].Value.ToString());
        }

        private void B02deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.B02_study_courses_to_pupils_classes.Where(x => x.id == id2).FirstOrDefault();
            if (row == null) return;

            bd.B02_study_courses_to_pupils_classes.Remove(row);
            bd.SaveChanges();

            updateB02();
        }
    }
}
