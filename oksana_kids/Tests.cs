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

        public int testID;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet64.T03_view_tt_modules". При необходимости она может быть перемещена или удалена.
            this.t03_view_tt_modulesTableAdapter.Fill(this.bd_kidsDataSet64.T03_view_tt_modules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet60.T05_view_test_passing_results". При необходимости она может быть перемещена или удалена.
            this.t05_view_test_passing_resultsTableAdapter.Fill(this.bd_kidsDataSet60.T05_view_test_passing_results);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet58.R10_next_action_variants". При необходимости она может быть перемещена или удалена.
            this.r10_next_action_variantsTableAdapter.Fill(this.bd_kidsDataSet58.R10_next_action_variants);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet57.T09_comment_variants_on_passing_tasks". При необходимости она может быть перемещена или удалена.
            this.t09_comment_variants_on_passing_tasksTableAdapter.Fill(this.bd_kidsDataSet57.T09_comment_variants_on_passing_tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet56.R11_variants_of_passing_tasks_results_analysis". При необходимости она может быть перемещена или удалена.
            this.r11_variants_of_passing_tasks_results_analysisTableAdapter.Fill(this.bd_kidsDataSet56.R11_variants_of_passing_tasks_results_analysis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet55.R12_instructions_to_test_tasks_types". При необходимости она может быть перемещена или удалена.
            this.r12_instructions_to_test_tasks_typesTableAdapter.Fill(this.bd_kidsDataSet55.R12_instructions_to_test_tasks_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet54.T08_audio_video_tracks". При необходимости она может быть перемещена или удалена.
            this.t08_audio_video_tracksTableAdapter.Fill(this.bd_kidsDataSet54.T08_audio_video_tracks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet53.T07_soundtracks". При необходимости она может быть перемещена или удалена.
            this.t07_soundtracksTableAdapter.Fill(this.bd_kidsDataSet53.T07_soundtracks);
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

        private void T02_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T02.CurrentRow.Cells[0].Value.ToString());
        }

        private void test_construct_button_Click(object sender, EventArgs e)
        {
            AdaptiveTestConstructor a = new AdaptiveTestConstructor(testName, testID);
            a.Show();
        }

        private void T02_Click(object sender, EventArgs e)
        {
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
                testID = (int)item.id_test;
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
            var data = from d in bd.T01_personalities
                       join c in bd.T04_testing_tasks on d.id_person equals c.id_author
                       join s in bd.R03_testing_types on c.code_type equals s.code_type
                       select new
                       {
                             name_task = c.name_task,
                             fio = d.surname + " " + d.name.Substring(0, 1) + ". " + d.patronymic.Substring(0, 1) + ".",
                             date_create = c.date_create,
                             date_correct = c.date_correct,
                             name_type = s.name_type,
                             file_location = c.file_location,
                             note = c.note
                       };
            T04.DataSource = data.ToList();
        }
        
        private void T04_file_location_Click(object sender, EventArgs e)
        {
            //Regex reg = new Regex(@"\\t{1}.*(.txt)");

            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                var match = Regex.Match(OPF.FileName, @"te{1}.*(.txt)").ToString();
                //MessageBox.Show(match.ToString());
                filePath = match.ToString();
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

            updateT04();
        }

        private void T04changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.T04_testing_tasks.Where(x => x.id_task == id).FirstOrDefault();
            if (row == null) return;

            row.name_task = T04.CurrentRow.Cells[0].Value.ToString();
            row.date_create = T04.CurrentRow.Cells[2].Value.ToString();
            row.date_correct = DateTime.Now.ToString("dd.MM.yyy");
            row.file_location = T04.CurrentRow.Cells[5].Value.ToString();
            row.note = T04.CurrentRow.Cells[6].Value.ToString();

            bd.SaveChanges();

            updateT04();
        }

        private void T04deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.T04_testing_tasks.Where(x => x.id_task == id).FirstOrDefault();
            if (row == null) return;

            bd.T04_testing_tasks.Remove(row);
            bd.SaveChanges();

            updateT04();
        }

        #endregion

        #region T03

        private int IDaddTM; // дополнительный обучающий материал
        private int IDTZ; // тестовое задание, чтоб на него модуль повесить
        private int IDCV; // вариант коммента по окончанию ТЗ
              
        private void T03_additional_teaching_material_add_Click(object sender, EventArgs e)
        {
            AdditionalTeachingMaterial a = new AdditionalTeachingMaterial(this);
            a.Show();
        }

        public void fillATM(int id, string name)
        {
            IDaddTM = id;
            T03_additional_teaching_material.Clear();
            T03_additional_teaching_material.Text = name;
        }

        private void T03_id_task_Click(object sender, EventArgs e)
        {
            ChooseTZForModulesTZ c = new ChooseTZForModulesTZ(this);
            c.Show();
        }

        public void fillTZ(int id, string name)
        {
            IDTZ = id;
            T03_id_task_name.Clear();
            T03_id_task_name.Text = name;
        }

        private void T03_id_comment_Click(object sender, EventArgs e)
        {
            CommentVariantsOnPassigTasksChoose co = new CommentVariantsOnPassigTasksChoose(this);
            co.Show();
        }

        public void fillCV(int id)
        {
            IDTZ = id;
        }

        private void updateT03()
        {
            var data = from t3 in bd.T03_testing_task_modules
                       join t8 in bd.T08_audio_video_tracks on t3.id_av_track equals t8.id_av_track
                       join r11 in bd.R11_variants_of_passing_tasks_results_analysis on t3.code_variant equals r11.code_variant
                       join r10 in bd.R10_next_action_variants on t3.code_action equals r10.code_action
                       join r12 in bd.R12_instructions_to_test_tasks_types on t3.code_instruction equals r12.code_instruction
                       join t4 in bd.T04_testing_tasks on t3.id_task equals t4.id_task
                       join t7 in bd.T07_soundtracks on t3.id_track equals t7.id_track
                       join t6 in bd.T06_teaching_materials on t3.additional_teaching_material equals t6.id_teach_material
                       join t9 in bd.T09_comment_variants_on_passing_tasks on t3.id_comment equals t9.id_comment
                       join r13 in bd.R13_play_result_variants on t9.code_play_result equals r13.code_play_result
                       select new
                       {
                           id_module = t3.id_module,
                           name_task = t4.name_task + "(" + t4.id_task + ")",
                           name_track = t7.name_track,
                           name_av_track = t8.name_av_track,
                           name_instruction = r12.name_instruction,
                           name_variant = r11.name_variant,
                           name_play_result = r13.name_play_result,
                           comment_view_duration_sec = t3.comment_view_duration_sec,
                           max_passing_duration_sec = t3.max_passing_duration_sec,
                           name_action = r10.name_action,
                           description = t6.description,
                           note = t3.note
                       };
            T03.DataSource = data.ToList();
        }

        private void T03addButton_Click(object sender, EventArgs e)
        {
            if (T03_id_task_name.Text == "" || T03_comment_view_duration_sec.Text == "" || T03_max_passing_duration_sec.Text == "" || T03_additional_teaching_material.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new T03_testing_task_modules()
                {
                    id_track = int.Parse(T03_id_track.SelectedValue.ToString()),
                    id_av_track = int.Parse(T03_id_av_track.SelectedValue.ToString()),
                    code_instruction = int.Parse(T03_code_instruction.SelectedValue.ToString()),
                    id_task = IDTZ,
                    code_variant = int.Parse(T03_code_variant.SelectedValue.ToString()),
                    id_comment = IDCV, // ???
                    comment_view_duration_sec = int.Parse(T03_comment_view_duration_sec.ToString()),
                    max_passing_duration_sec = int.Parse(T03_max_passing_duration_sec.ToString()),
                    code_action = int.Parse(T03_code_action.SelectedValue.ToString()),
                    note = note.Text == "" ? " " : note.Text,
                    additional_teaching_material = IDaddTM,
                };
                bd.T03_testing_task_modules.Add(person);
                bd.SaveChanges();

            }
            T03_id_task_name.Clear();
            T03_comment_view_duration_sec.Clear();
            T03_max_passing_duration_sec.Clear();
            T03_additional_teaching_material.Clear();
            T03_note.Clear();

            updateT03();
        }

        private void T03_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T03.CurrentRow.Cells[11].Value.ToString());
        }
   

    


        #endregion

        
    }
}