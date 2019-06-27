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

        int id;

        public References(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        private void References_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet44.R15_task_key_words". При необходимости она может быть перемещена или удалена.
            this.r15_task_key_wordsTableAdapter.Fill(this.bd_kidsDataSet44.R15_task_key_words);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet43.R14_track_types". При необходимости она может быть перемещена или удалена.
            this.r14_track_typesTableAdapter.Fill(this.bd_kidsDataSet43.R14_track_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet42.R13_play_result_variants". При необходимости она может быть перемещена или удалена.
            this.r13_play_result_variantsTableAdapter.Fill(this.bd_kidsDataSet42.R13_play_result_variants);
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

            this.CBcorrelate.Click += new EventHandler(this.CBchoose_Click);
            this.CBfreeAnswer.Click += new EventHandler(this.CBchoose_Click);
            this.CBrange.Click += new EventHandler(this.CBchoose_Click);
        }

        #region R01

        private void R01_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R01.CurrentRow.Cells[0].Value.ToString());
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
            var row = bd.R01_people_category.Where(x => x.code_category == id).FirstOrDefault();
            if (row == null) return;

            row.name_category = R01.CurrentRow.Cells[1].Value.ToString();
            row.note = R01.CurrentRow.Cells[2].Value.ToString();

            bd.SaveChanges();

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

        #endregion R01

        private void References_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[1].Show(); 
        }

        private void T01R07bind_Click(object sender, EventArgs e)
        {
            MethodicalMaterialBind m = new MethodicalMaterialBind();
            m.Show();
        }
   
        private void CBchoose_Click(object sender, EventArgs e)
        {
            var obj = sender as CheckBox;
            var checkboxes = new List<CheckBox>() { this.CBchoose, this.CBcorrelate, this.CBfreeAnswer, this.CBrange };
            foreach (var item in checkboxes)
            {
                if (obj.Name == item.Name) obj.Checked = true;
                else item.Checked = false;
            }

            if (obj.Name == this.CBchoose.Name)
            {
                R03_name_type.Clear();
                R03_name_type.Text += "выбор из предопределенного набора, ";
            }
            else if (obj.Name == this.CBcorrelate.Name)
            {
                R03_name_type.Clear();
                R03_name_type.Text += "соответствие, ";
            }
            else if (obj.Name == this.CBfreeAnswer.Name)
            {
                R03_name_type.Clear();
                R03_name_type.Text += "свободный ввод ответа, ";
            }
            else if (obj.Name == this.CBrange.Name)
            {
                R03_name_type.Clear();
                R03_name_type.Text += "ранжирование, ";
            }
        }

        #region R02

        private void B02study_cources_to_pupils_classes_Click(object sender, EventArgs e)
        {
            StudyCourcesToPupilsClassesBind s = new StudyCourcesToPupilsClassesBind();
            s.Show();
        }

        private void R02_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R02.CurrentRow.Cells[3].Value.ToString());
        }

        private void R02addButton_Click(object sender, EventArgs e)
        {
            if (R02_name_class.Text == "" || R02_study_years.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R02_pupils_classes()
                {
                    name_class = R02_name_class.Text,
                    study_years = R02_study_years.Text,
                    note = R02_note.Text == "" ? " " : R02_note.Text
                };
                bd.R02_pupils_classes.Add(person);
                bd.SaveChanges();
                
            }

            R02_name_class.Clear();
            R02_study_years.Clear();
            R02_note.Clear();
            updateR02();
        }

        private void updateR02()
        {
            var data = bd.R02_pupils_classes.Select(x => new {x.code_class, x.name_class, x.study_years, x.note});
            R02.DataSource = data.ToList();
        } 

        private void R02changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R02_pupils_classes.Where(x => x.code_class == id).FirstOrDefault();
            if (row == null) return;

            row.name_class = R02.CurrentRow.Cells[0].Value.ToString();
            row.study_years = R02.CurrentRow.Cells[1].Value.ToString();
            row.note = R02.CurrentRow.Cells[2].Value.ToString();

            bd.SaveChanges();
        }

        private void R02deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R02_pupils_classes.Where(x => x.code_class == id).FirstOrDefault();
            if (row == null) return;

            bd.R02_pupils_classes.Remove(row);
            bd.SaveChanges();

            updateR02();
        }

        #endregion

        #region R03

        private void updateR03()
        {
            var data = bd.R03_testing_types.Select(x => new { x.code_type, x.name_type, x.note });
            R03.DataSource = data.ToList();
        }

        private void R03_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R03.CurrentRow.Cells[2].Value.ToString());
        }

        private void R03addButton_Click(object sender, EventArgs e)
        {
            if (R03_name_type.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R03_testing_types()
                {
                    name_type = R03_name_type.Text,
                    note = R03_note.Text == "" ? " " : R03_note.Text
                };
                bd.R03_testing_types.Add(person);
                bd.SaveChanges();

            }

            R03_name_type.Clear();
            R03_note.Clear();
            updateR03();
        }

        private void R03changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R03_testing_types.Where(x => x.code_type == id).FirstOrDefault();
            if (row == null) return;

            row.name_type = R03.CurrentRow.Cells[0].Value.ToString();
            row.note = R03.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R03deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R03_testing_types.Where(x => x.code_type == id).FirstOrDefault();
            if (row == null) return;

            bd.R03_testing_types.Remove(row);
            bd.SaveChanges();

            updateR03();
        }

        private void CBchoose_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CBchoose, "выбор лишнего|верного утверждения, картинка|текст в вопросе|в ответе|везде");
        }

        private void CBcorrelate_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CBcorrelate, "количество групп, картинка|текст в вопросе |в ответе|везде");
        }

        #endregion

        #region R04

        private void updateR04()
        {
            var data = bd.R04_end_testing_reasons.Select(x => new { x.code_end_reason, x.name_end_reason, x.note });
            R04.DataSource = data.ToList();
        }

        private void R04_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R04.CurrentRow.Cells[2].Value.ToString());
        }

        private void R04addButton_Click(object sender, EventArgs e)
        {
            if (R04_name_end_reason.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R04_end_testing_reasons()
                {
                    name_end_reason = R04_name_end_reason.Text,
                    note = R04_note.Text == "" ? " " : R04_note.Text
                };
                bd.R04_end_testing_reasons.Add(person);
                bd.SaveChanges();

            }

            R04_name_end_reason.Clear();
            R04_note.Clear();
            updateR04();
        }

        private void R04chagebutton_Click(object sender, EventArgs e)
        {
            var row = bd.R04_end_testing_reasons.Where(x => x.code_end_reason == id).FirstOrDefault();
            if (row == null) return;

            row.name_end_reason = R04.CurrentRow.Cells[0].Value.ToString();
            row.note = R04.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R04deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R04_end_testing_reasons.Where(x => x.code_end_reason == id).FirstOrDefault();
            if (row == null) return;

            bd.R04_end_testing_reasons.Remove(row);
            bd.SaveChanges();

            updateR04();
        }

        #endregion

        #region R05

        private void R05_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R05.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR05()
        {
            var data = bd.R05_legal_ownership_forms.Select(x => new { x.code_ownership, x.name_ownership, x.note });
            R05.DataSource = data.ToList();
        }

        private void R05addButton_Click(object sender, EventArgs e)
        {
            if (R05_name_ownership.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R05_legal_ownership_forms()
                {
                    name_ownership = R05_name_ownership.Text,
                    note = R05_note.Text == "" ? " " : R05_note.Text
                };
                bd.R05_legal_ownership_forms.Add(person);
                bd.SaveChanges();

            }

            R05_name_ownership.Clear();
            R05_note.Clear();
            updateR05();
        }

        private void R05changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R05_legal_ownership_forms.Where(x => x.code_ownership == id).FirstOrDefault();
            if (row == null) return;

            row.name_ownership = R05.CurrentRow.Cells[0].Value.ToString();
            row.note = R05.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R05deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R05_legal_ownership_forms.Where(x => x.code_ownership == id).FirstOrDefault();
            if (row == null) return;

            bd.R05_legal_ownership_forms.Remove(row);
            bd.SaveChanges();

            updateR05();
        }

        #endregion

        #region R06

        private void R06_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R06.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR06()
        {
            var data = bd.R06_testing_aims.Select(x => new { x.code_aim, x.name_aim, x.note });
            R06.DataSource = data.ToList();
        }

        private void R06addButton_Click(object sender, EventArgs e)
        {
            if (R06_name_aim.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R06_testing_aims()
                {
                    name_aim = R06_name_aim.Text,
                    note = R06_note.Text == "" ? " " : R06_note.Text
                };
                bd.R06_testing_aims.Add(person);
                bd.SaveChanges();

            }

            R06_name_aim.Clear();
            R06_note.Clear();
            updateR06();
        }

        private void R06changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R06_testing_aims.Where(x => x.code_aim == id).FirstOrDefault();
            if (row == null) return;

            row.name_aim = R06.CurrentRow.Cells[0].Value.ToString();
            row.note = R06.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R06deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R06_testing_aims.Where(x => x.code_aim == id).FirstOrDefault();
            if (row == null) return;

            bd.R06_testing_aims.Remove(row);
            bd.SaveChanges();

            updateR06();
        }

        #endregion

        #region R07

        private void R07_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R07.CurrentRow.Cells[3].Value.ToString());
        }

        private void updateR07()
        {
            var data = bd.R07_methodical_materials.Select(x => new { x.id_method_material, x.description, x.file_location, x.note });
            R07.DataSource = data.ToList();
        }

        private void R07addButton_Click(object sender, EventArgs e)
        {
            if (R07_description.Text == "" || R07_file_location.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R07_methodical_materials()
                {
                    description = R07_description.Text,
                    file_location = R07_file_location.Text,
                    note = R07_note.Text == "" ? " " : R07_note.Text
                };
                bd.R07_methodical_materials.Add(person);
                bd.SaveChanges();

            }

            R07_description.Clear();
            R07_file_location.Clear();
            R07_note.Clear();
            updateR07();
        }

        private void R07changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R07_methodical_materials.Where(x => x.id_method_material == id).FirstOrDefault();
            if (row == null) return;

            row.description = R07.CurrentRow.Cells[0].Value.ToString();
            row.file_location = R07.CurrentRow.Cells[1].Value.ToString();
            row.note = R07.CurrentRow.Cells[2].Value.ToString();

            bd.SaveChanges();
        }

        private void R07deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R07_methodical_materials.Where(x => x.id_method_material == id).FirstOrDefault();
            if (row == null) return;

            bd.R07_methodical_materials.Remove(row);
            bd.SaveChanges();

            updateR07();
        }

        #endregion

        #region R08

        private void R08_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R08.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR08()
        {
            var data = bd.R08_study_courses.Select(x => new { x.code_course, x.name_course, x.note });
            R08.DataSource = data.ToList();
        }

        private void R08addButton_Click(object sender, EventArgs e)
        {
            if (R08_name_course.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R08_study_courses()
                {
                    name_course = R08_name_course.Text,
                    note = R08_note.Text == "" ? " " : R08_note.Text
                };
                bd.R08_study_courses.Add(person);
                bd.SaveChanges();

            }

            R08_name_course.Clear();
            R08_note.Clear();
            updateR08();
        }

        private void R08changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R08_study_courses.Where(x => x.code_course == id).FirstOrDefault();
            if (row == null) return;

            row.name_course = R08.CurrentRow.Cells[0].Value.ToString();
            row.note = R08.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R08deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R08_study_courses.Where(x => x.code_course == id).FirstOrDefault();
            if (row == null) return;

            bd.R08_study_courses.Remove(row);
            bd.SaveChanges();

            updateR08();
        }

        private void B03study_subjects_to_courses_Click(object sender, EventArgs e)
        {
            StudySubjectsToCourcesBind b = new StudySubjectsToCourcesBind();
            b.Show();
        }

        #endregion

        #region R09

        private void R09_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R09.CurrentRow.Cells[3].Value.ToString());
        }

        private void updateR09()
        {
            var data = bd.R09_study_subjects.Select(x => new { x.code_subject, x.name_subject, x.academ_hours, x.note });
            R09.DataSource = data.ToList();
        }

        private void R09addButton_Click(object sender, EventArgs e)
        {
            if (R09_name_subject.Text == "" || R09_academ_hours.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R09_study_subjects()
                {
                    name_subject = R09_name_subject.Text,
                    academ_hours = int.Parse(R09_academ_hours.Text),
                    note = R09_note.Text == "" ? " " : R09_note.Text
                };
                bd.R09_study_subjects.Add(person);
                bd.SaveChanges();

            }

            R09_name_subject.Clear();
            R09_academ_hours.Clear();
            R09_note.Clear();
            updateR09();
        }

        private void R09changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R09_study_subjects.Where(x => x.code_subject == id).FirstOrDefault();
            if (row == null) return;

            row.name_subject = R09.CurrentRow.Cells[0].Value.ToString();
            row.academ_hours = int.Parse(R09.CurrentRow.Cells[1].Value.ToString());
            row.note = R09.CurrentRow.Cells[2].Value.ToString();

            bd.SaveChanges();
        }

        private void R09deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R09_study_subjects.Where(x => x.code_subject == id).FirstOrDefault();
            if (row == null) return;

            bd.R09_study_subjects.Remove(row);
            bd.SaveChanges();

            updateR09();
        }

        private void B04_test_tasks_to_study_subjects_Click(object sender, EventArgs e)
        {
            TestTasksToStudySubjectsBind t = new TestTasksToStudySubjectsBind();
            t.Show();
        }

        #endregion

        #region R10

        private void R10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R10.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR10()
        {
            var data = bd.R10_next_action_variants.Select(x => new { x.code_action, x.name_action, x.note });
            R10.DataSource = data.ToList();
        }

        private void R10addButton_Click(object sender, EventArgs e)
        {
            if (R10_name_action.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R10_next_action_variants()
                {
                    name_action = R10_name_action.Text,
                    note = R10_note.Text == "" ? " " : R10_note.Text
                };
                bd.R10_next_action_variants.Add(person);
                bd.SaveChanges();

            }

            R10_name_action.Clear();
            R10_note.Clear();
            updateR10();
        }

        private void R10changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R10_next_action_variants.Where(x => x.code_action == id).FirstOrDefault();
            if (row == null) return;

            row.name_action = R10.CurrentRow.Cells[0].Value.ToString();
            row.note = R10.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R10deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R10_next_action_variants.Where(x => x.code_action == id).FirstOrDefault();
            if (row == null) return;

            bd.R10_next_action_variants.Remove(row);
            bd.SaveChanges();

            updateR10();
        }

        #endregion

        #region R11

        private void R11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R11.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR11()
        {
            var data = bd.R11_variants_of_passing_tasks_results_analysis.Select(x => new { x.code_variant, x.name_variant, x.note });
            R11.DataSource = data.ToList();
        }

        private void R11addButton_Click(object sender, EventArgs e)
        {
            if (R11_name_variant.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R11_variants_of_passing_tasks_results_analysis()
                {
                    name_variant = R11_name_variant.Text,
                    note = R11_note.Text == "" ? " " : R11_note.Text
                };
                bd.R11_variants_of_passing_tasks_results_analysis.Add(person);
                bd.SaveChanges();

            }

            R11_name_variant.Clear();
            R11_note.Clear();
            updateR11();
        }

        private void R11changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R11_variants_of_passing_tasks_results_analysis.Where(x => x.code_variant == id).FirstOrDefault();
            if (row == null) return;

            row.name_variant = R11.CurrentRow.Cells[0].Value.ToString();
            row.note = R11.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R11deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R11_variants_of_passing_tasks_results_analysis.Where(x => x.code_variant == id).FirstOrDefault();
            if (row == null) return;

            bd.R11_variants_of_passing_tasks_results_analysis.Remove(row);
            bd.SaveChanges();

            updateR11();
        }

        #endregion

        #region R12

        private void R12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R12.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR12()
        {
            var data = bd.R12_instructions_to_test_tasks_types.Select(x => new { x.code_instruction, x.name_instruction, x.note });
            R12.DataSource = data.ToList();
        }

        private void R12addButton_Click(object sender, EventArgs e)
        {
            if (R12_name_instruction.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R12_instructions_to_test_tasks_types()
                {
                    name_instruction = R12_name_instruction.Text,
                    note = R12_note.Text == "" ? " " : R12_note.Text
                };
                bd.R12_instructions_to_test_tasks_types.Add(person);
                bd.SaveChanges();

            }

            R12_name_instruction.Clear();
            R12_note.Clear();
            updateR12();
        }

        private void R12changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R12_instructions_to_test_tasks_types.Where(x => x.code_instruction == id).FirstOrDefault();
            if (row == null) return;

            row.name_instruction = R12.CurrentRow.Cells[0].Value.ToString();
            row.note = R12.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R12deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R12_instructions_to_test_tasks_types.Where(x => x.code_instruction == id).FirstOrDefault();
            if (row == null) return;

            bd.R12_instructions_to_test_tasks_types.Remove(row);
            bd.SaveChanges();

            updateR12();
        }

        #endregion

        #region R13

        private void R13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R13.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR13()
        {
            var data = bd.R13_play_result_variants.Select(x => new { x.code_play_result, x.name_play_result, x.note });
            R13.DataSource = data.ToList();
        }

        private void R13addButton_Click(object sender, EventArgs e)
        {
            if (R13_name_play_result.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R13_play_result_variants()
                {
                    name_play_result = R13_name_play_result.Text,
                    note = R13_note.Text == "" ? " " : R13_note.Text
                };
                bd.R13_play_result_variants.Add(person);
                bd.SaveChanges();

            }

            R13_name_play_result.Clear();
            R13_note.Clear();
            updateR13();
        }

        private void R13changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R13_play_result_variants.Where(x => x.code_play_result == id).FirstOrDefault();
            if (row == null) return;

            row.name_play_result = R13.CurrentRow.Cells[0].Value.ToString();
            row.note = R13.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R13deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R13_play_result_variants.Where(x => x.code_play_result == id).FirstOrDefault();
            if (row == null) return;

            bd.R13_play_result_variants.Remove(row);
            bd.SaveChanges();

            updateR13();
        }
        
        #endregion

        #region R14

        private void R14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R14.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR14()
        {
            var data = bd.R14_track_types.Select(x => new { x.code_type, x.name_type, x.note });
            R14.DataSource = data.ToList();
        }

        private void R14addButton_Click(object sender, EventArgs e)
        {
            if (R14_name_type.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R14_track_types()
                {
                    name_type = R14_name_type.Text,
                    note = R14_note.Text == "" ? " " : R14_note.Text
                };
                bd.R14_track_types.Add(person);
                bd.SaveChanges();

            }

            R14_name_type.Clear();
            R14_note.Clear();
            updateR14();
        }

        private void R14changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R14_track_types.Where(x => x.code_type == id).FirstOrDefault();
            if (row == null) return;

            row.name_type = R14.CurrentRow.Cells[0].Value.ToString();
            row.note = R14.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R14deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R14_track_types.Where(x => x.code_type == id).FirstOrDefault();
            if (row == null) return;

            bd.R14_track_types.Remove(row);
            bd.SaveChanges();

            updateR14();
        }

        #endregion

        #region R15

        private void R15_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(R15.CurrentRow.Cells[2].Value.ToString());
        }

        private void updateR15()
        {
            var data = bd.R15_task_key_words.Select(x => new { x.code_key_word, x.name_key_word, x.note });
            R15.DataSource = data.ToList();
        }

        private void R15addButton_Click(object sender, EventArgs e)
        {
            if (R15_name_key_word.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new R15_task_key_words()
                {
                    name_key_word = R15_name_key_word.Text,
                    note = R15_note.Text == "" ? " " : R15_note.Text
                };
                bd.R15_task_key_words.Add(person);
                bd.SaveChanges();

            }

            R15_name_key_word.Clear();
            R15_note.Clear();
            updateR15();
        }

        private void R15changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.R15_task_key_words.Where(x => x.code_key_word == id).FirstOrDefault();
            if (row == null) return;

            row.name_key_word = R15.CurrentRow.Cells[0].Value.ToString();
            row.note = R15.CurrentRow.Cells[1].Value.ToString();

            bd.SaveChanges();
        }

        private void R15deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.R15_task_key_words.Where(x => x.code_key_word == id).FirstOrDefault();
            if (row == null) return;

            bd.R15_task_key_words.Remove(row);
            bd.SaveChanges();

            updateR15();
        }

        #endregion
    }

}
