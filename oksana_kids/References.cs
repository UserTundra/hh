using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class References : Form
    {
        public int tabIndex;

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        public References(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        private void References_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet27.R12_instructions_to_test_tasks_types". При необходимости она может быть перемещена или удалена.
            this.r12_instructions_to_test_tasks_typesTableAdapter.Fill(this.bd_kidsDataSet27.R12_instructions_to_test_tasks_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet26.R10_next_action_variants". При необходимости она может быть перемещена или удалена.
            this.r10_next_action_variantsTableAdapter.Fill(this.bd_kidsDataSet26.R10_next_action_variants);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet25.R09_study_subjects". При необходимости она может быть перемещена или удалена.
            this.r09_study_subjectsTableAdapter.Fill(this.bd_kidsDataSet25.R09_study_subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet24.R07_methodical_materials". При необходимости она может быть перемещена или удалена.
            this.r07_methodical_materialsTableAdapter.Fill(this.bd_kidsDataSet24.R07_methodical_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet23.R08_study_courses". При необходимости она может быть перемещена или удалена.
            this.r08_study_coursesTableAdapter.Fill(this.bd_kidsDataSet23.R08_study_courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet22.R06_testing_aims". При необходимости она может быть перемещена или удалена.
            this.r06_testing_aimsTableAdapter.Fill(this.bd_kidsDataSet22.R06_testing_aims);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet21.R05_legal_ownership_forms". При необходимости она может быть перемещена или удалена.
            this.r05_legal_ownership_formsTableAdapter1.Fill(this.bd_kidsDataSet21.R05_legal_ownership_forms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet20.R05_legal_ownership_forms". При необходимости она может быть перемещена или удалена.
            this.r05_legal_ownership_formsTableAdapter.Fill(this.bd_kidsDataSet20.R05_legal_ownership_forms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet19.R04_end_testing_reasons". При необходимости она может быть перемещена или удалена.
            this.r04_end_testing_reasonsTableAdapter.Fill(this.bd_kidsDataSet19.R04_end_testing_reasons);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet18.R03_testing_types". При необходимости она может быть перемещена или удалена.
            this.r03_testing_typesTableAdapter.Fill(this.bd_kidsDataSet18.R03_testing_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet17.R02_pupils_classes". При необходимости она может быть перемещена или удалена.
            this.r02_pupils_classesTableAdapter.Fill(this.bd_kidsDataSet17.R02_pupils_classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.R01_people_category". При необходимости она может быть перемещена или удалена.
            this.r01_people_categoryTableAdapter.Fill(this.bd_kidsDataSet.R01_people_category);
            tabControl1.SelectTab(tabIndex);
        }

        private void R01addButton_Click(object sender, EventArgs e)
        {
            if (R01_name_category.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                try
                {
                    bd_kidsDataSet.R01_people_categoryRow row;
                    row = bd_kidsDataSet.R01_people_category.NewR01_people_categoryRow();
                    row.name_category = R01_name_category.Text;
                    row.note = R01_note.Text == " " ? " " : R01_note.Text;

                    this.bd_kidsDataSet.R01_people_category.Rows.Add(row);
                    this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Возникли неприятности");
                }
            }

            R01_name_category.Clear();
            R01_note.Clear();
            R01.Refresh();
        }

        private void R01changeButton_Click(object sender, EventArgs e)
        {
            try
            { 
                bd_kidsDataSet.R01_people_categoryRow row;
                row = bd_kidsDataSet.R01_people_category.FindBycode_category((long)R01.CurrentRow.Cells[0].Value);

                row.name_category = R01.CurrentRow.Cells[1].Value.ToString();
                row.note = R01.CurrentRow.Cells[2].Value.ToString();

                this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникли неприятности");
            }
            R01.Refresh();

        }

        private void R01deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                bd_kidsDataSet.R01_people_categoryRow row;
                row = bd_kidsDataSet.R01_people_category.FindBycode_category((long)R01.CurrentRow.Cells[0].Value);
                row.Delete();
                this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникли неприятности");
            }
            R01.Refresh();
        }

        private void References_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[1].Show(); 
        }

        private void T01R07bind_Click(object sender, EventArgs e)
        {
            MethodicalMaterialBind m = new MethodicalMaterialBind();
            m.Show();
        }

        
    }
}
