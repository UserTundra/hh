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
    public partial class TestForm : Form
    {
        public const string FINISH_STRING = "Следующий вопрос";
        public const string NEXT_TASK_STRING = "Следующий вопрос";
        public const int MAX_BLOCKS_SIZE = 8;

        public int MAX_FAILS = 44;
        private int _ElapsedTime;
        public int ElapsedTime {
            get { return _ElapsedTime; }
            set
            {
                _ElapsedTime = value;
                this.timeLabel.Text = "Осталось времени: " + _ElapsedTime.ToString();
            }
        }

        public TestParent callback;

        public int SelectedCheckBoxIdx = 0;
        public int RightAnswersCount = 0;
        public int SummaryFailCount = 0;

        public string wrongAnswerImagePath = "";

        public List<SimplyTest> testCollection;
        public int currentTestIndex = 0;
        private SimplyTest _currentValue;
        private CheckBox _selectedCheckBox = null;
        private PictureBox _selectedPicture = null;
        public SimplyTest CurrentTest
        {
            get
            {
                return _currentValue;
            }
            set
            {
                InitTest(value);
                _currentValue = value;
            }
        }

        private void InitTest(SimplyTest test)
        {
            SummaryFailCount = 0;
            this.labelQuestionBody.Text = test.Question.StringValue;
            if (test.Question.ImageValue != null)
            { 
                this.pictureBoxQuestion1.Image = test.Question.ImageValue;
                pictureBoxQuestion1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            labelQuestionTitle.Text = "Вопрос Номер: " + (this.currentTestIndex+1);

            for (int i = 1; i <= MAX_BLOCKS_SIZE; i++)
            {
                var checkBox = this.Controls["checkBox" + i] as CheckBox;
                checkBox.Checked = false;
            }


            int counter = 0;
            foreach (var el in test.Variables)
            {
                try {
                    this.Controls["checkBox" + (++counter)].Text = el.StringValue;
                    this.Controls["pictureBox" + (counter)].BackgroundImage = el.ImageValue;
                } catch(Exception ee)
                {
                    MessageBox.Show("Упс, что-то пошло не так!");
                }
            }
            for (int i = 1; i <= MAX_BLOCKS_SIZE; i++)
            {
                if(i < counter + 1)
                {
                    
                    this.Controls["checkBox" + i].Visible = true;
                    this.Controls["pictureBox" + i].Visible = true;
                }
                else
                {
                    this.Controls["checkBox" + i].Visible = false;
                    this.Controls["pictureBox" + i].Visible = false;
                }
                
            }

        }

        public int AnswersCount { get; set; }

        public TestForm(List<SimplyTest> tests, TestParent callback, int width, int height, int max_fails=44, int time = 999999, string wrongAnswerImagePath = "")
        {
            InitializeComponent();

            this.Width = width;
            this.Height = height;
            this.callback = callback;
            this.MAX_FAILS = max_fails;
            this.ElapsedTime = time;
            this.wrongAnswerImagePath = wrongAnswerImagePath;

            this.testCollection = tests;
            this.CurrentTest = this.testCollection.FirstOrDefault();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.AnswersCount = 1;
            checkBoxInit();
            buttonNext.Text = NEXT_TASK_STRING;
            
        }

        private void checkBoxInit()
        {
            this.checkBox1.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox2.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox3.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox4.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox5.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox6.Click += new System.EventHandler(this.checkBoxClick);


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.CurrentTest.RightIdx == this.SelectedCheckBoxIdx) {
                new Zoom("Молодец! Всё правильно!").Show();
                
                this.RightAnswersCount++;
            }
            else
            {
                if (this._selectedCheckBox.Visible) { 
                    SummaryFailCount++;
                    new Zoom("Неправильно. Подумай ещё раз!", callback.ShowWrongAnswerPictures).Show();
                }
                _selectedCheckBox.Visible = false;
                _selectedPicture.Visible = false;
                if(SummaryFailCount <= MAX_FAILS)
                    return;
            }
            if (currentTestIndex < testCollection.Count - 1) {
                this.CurrentTest = testCollection[++currentTestIndex];
                QuestionInit(this.CurrentTest);
            }else
            {
                //MessageBox.Show("Первая часть тестирования окончена\n\rВерных ответов: "+this.RightAnswersCount);
                this.callback.SummaryRightAnswers += this.RightAnswersCount;
                this.Hide();
                this.callback.testnumber = this.currentTestIndex + 1;
                this.callback.ShowNext();
            }
            
        }

        private void QuestionInit(AbstractTest test)
        {

        }

        private void checkBoxClick(object sender, EventArgs e)
        {
            if(this.AnswersCount == 1)
            {
                var currentCheckBox = sender as CheckBox;
                var currentCheckBoxName = currentCheckBox.Name;
                this.SelectedCheckBoxIdx = int.Parse(currentCheckBox.Name.Substring(currentCheckBox.Name.Length - 1));
                var checkBoxArrayToCheck = new List<CheckBox>()
                {
                    this.checkBox1,
                    this.checkBox2,
                    this.checkBox3,
                    this.checkBox4,
                    this.checkBox5,
                    this.checkBox6,
                    this.checkBox7,
                };
                var pictureBoxArray = new List<PictureBox>()
                {
                    this.pictureBox1,
                    this.pictureBox2,
                    this.pictureBox3,
                    this.pictureBox4,
                    this.pictureBox5,
                    this.pictureBox6,
                    this.pictureBox7,
                };
                int idx = 0;
                int i = 0;
                foreach (CheckBox box in checkBoxArrayToCheck)
                {
                    if(box.Name != currentCheckBoxName)
                    {
                        box.Checked = false;
                    }
                    else
                    {
                        idx = i;
                        _selectedCheckBox = box;
                        box.Checked = true;
                    }
                    i++;
                }
                _selectedPicture = pictureBoxArray[idx];
            }
            if(this.currentTestIndex == this.testCollection.Count-1)
            {
                buttonNext.Text = FINISH_STRING;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms[1].Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ElapsedTime--;
            this.callback.time--;
            if (ElapsedTime == 0)
            {
                this.callback.SummaryRightAnswers += this.RightAnswersCount;
                this.Hide();
                this.callback.showMenu();
                this.callback.preClose();
                
            }
        }

        
    }
}
