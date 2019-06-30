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
    public partial class AddAnswersToTasks : Form
    {
        public AddAnswersToTasks(int taskID, string taskName)
        {
            InitializeComponent();
            this.taskID = taskID;
            this.taskName = taskName;
        }

        public int taskID;
        public string taskName = "";

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        private int id;

        private void AddAnswersToTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet78.R15_task_key_words". При необходимости она может быть перемещена или удалена.
            this.r15_task_key_wordsTableAdapter.Fill(this.bd_kidsDataSet78.R15_task_key_words);
            T11_name_task.Text = taskName;
            updateT04();
        }

        private void updateT04()
        {
            var data = from d in bd.T11_test_answers
                       join c in bd.R15_task_key_words on d.code_key_word equals c.code_key_word
                       join s in bd.T04_testing_tasks on d.id_task equals s.id_task
                       where s.id_task == taskID
                       select new
                       {
                           Ключ = c.name_key_word,
                           Текст = d.string_value,
                           Картинка = d.image_value,
                           Звук = d.sound_value,
                           Правильность = d.is_correct == 0 ? "нет" : d.is_correct == 1 ? "да" : "другое",
                           Группа = d.group_no
                       };
            T11.DataSource = data.ToList();
        }


        private void T11_code_key_word_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                if (T11_code_key_word.SelectedValue.ToString() == "2") //значит вопрос вообще
                {
                    T11_grouping.Enabled = false;
                    T11_group_no.Enabled = false;
                    T11_is_correct_no.Enabled = false;
                    T11_is_correct_yes.Enabled = false;
                }
                else
                {
                    T11_grouping.Enabled = true;
                    T11_group_no.Enabled = true;
                    T11_is_correct_no.Enabled = true;
                    T11_is_correct_yes.Enabled = true;
                }
            }
            catch(Exception ee) { }
        }

        private void T11_grouping_CheckedChanged(object sender, EventArgs e)
        {
            if (T11_grouping.Checked)
            {
                T11_group_no.Enabled = true;
                T11_is_correct_no.Enabled = false;
                T11_is_correct_yes.Enabled = false;
            }
            else
            {
                T11_group_no.Enabled = false;
                T11_is_correct_no.Enabled = true;
                T11_is_correct_yes.Enabled = true;
            }
        }
    }
}
