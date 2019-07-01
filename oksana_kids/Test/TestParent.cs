using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids.Test
{

    public partial class TestParent : Form
    {

        public int time;
        public int SummaryRightAnswers = 0;

        private TestFormsArgument Condition;

        public bd_kidsEntities1 bd = new bd_kidsEntities1();

        public TestParent(TestFormsArgument cond, int time = 999999, string wrongAnswerImagePath = "")
        {
            this.wrongAnswerImagePath = wrongAnswerImagePath;
            this.time = time;
            this.Condition = cond;
            InitializeComponent();
        }

        public string wrongAnswerImagePath = "";
        public int ShowWrongAnswerPictures()
        {
            if (wrongAnswerImagePath != "")
            {
                new Pictures(wrongAnswerImagePath, " ").Show();
            }
            return 0;
        }

        public int TestNumber = 1;

        private void TestParent_Load(object sender, EventArgs e)
        {
            MdiClient mdi;
            foreach(Control ctl in this.Controls)
            {
                try
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = this.BackColor;
                }catch(Exception ee) { }
            }
            this.Condition.IdxCurrentTest = -1; // then it will be 0 on ShowNext step
            ShowNext();
            


        }

        public int testnumber = 1;
        public void ShowNext()
        {
            var res = this.Condition.GetNextTest();
            if(res == null)
            {
                this.preClose();
                return;
            }
            if(this.Condition.IdxCurrentTest == 0)
            {
                this.IsMdiContainer = true;
                TestForm first = new TestForm(this.Condition.CurrentTest, this, this.Width, this.Height, 1, time);
                InitChildForm(first);
                first.Show();
            }
            if(this.Condition.IdxCurrentTest == 1) { 
                TestForm2 second = new TestForm2(this.Condition.CurrentTest,this.Condition.Callback,this);
                InitChildForm(second);
                second.Show();
            }
        }

        public void showMenu()
        {
            this.Condition.Callback.Show();
        }
        

        private void InitChildForm(Form form)
        {
            form.MdiParent = this;
            form.Left = 0;
            form.Top = 0;
        }


        public int ClearAnswers = 0;
         
        public void preClose()
        {
            MessageBox.Show("Тестирование окончено, верных ответов: " + this.SummaryRightAnswers);

            //bd_kidsEntities1 db = new bd_kidsEntities1();

            
            try {
                PupilSelectionWindow.timeEnd = DateTime.Now.ToShortTimeString();
                var allCount = this.Condition.testQuestionCount(); // all count
                float percent = (SummaryRightAnswers * 1.0f) / (allCount * 1.0f) * 100;
                float clearPercent = (ClearAnswers * 1.0f) / (allCount * 1.0f) * 100;
                bd.T05_test_passing_results.Add(new T05_test_passing_results()
                {
                    id_person = AuthorisationForm.peopleID,
                    perc_partially_right = clearPercent,
                    perc_totally_right = percent,
                    amount_passing_tests = allCount,
                    time_end = PupilSelectionWindow.timeEnd,
                    date_testing = PupilSelectionWindow.dateBegin,
                    time_start = PupilSelectionWindow.timeBegin,
                    code_end_reason = PupilSelectionWindow.endTestingReason,
                    id_test = PupilSelectionWindow.TestID
                });
                bd.SaveChanges();
            }catch(Exception ee)
            {
                MessageBox.Show("не удается сохранить результаты теста");
            }
            this.Condition.Callback.Show();
            this.Hide();
            
        }

        private void TestParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.preClose();
        }
    }
}
