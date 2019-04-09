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
        
        
        public int SummaryRightAnswers = 0;

        private TestFormsArgument Condition;

        public TestParent(TestFormsArgument cond)
        {
            this.Condition = cond;
            InitializeComponent();
        }

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
        public void ShowNext()
        {
            this.Condition.GetNextTest();
            if(this.Condition.IdxCurrentTest == 0)
            {
                this.IsMdiContainer = true;
                TestForm first = new TestForm(this.Condition.CurrentTest, this, this.Width, this.Height);
                InitChildForm(first);
                first.Show();
            }
            if(this.Condition.IdxCurrentTest == 1) { 
                TestForm2 second = new TestForm2(this.Condition.CurrentTest,this.Condition.Callback,this);
                InitChildForm(second);
                second.Show();
            }
        }

        private void InitChildForm(Form form)
        {
            form.MdiParent = this;
            form.Left = 0;
            form.Top = 0;
        }
        

        public void preClose()
        {
            MessageBox.Show("Тестирование окончено, верных ответов: " + this.SummaryRightAnswers);
            this.Hide();

        }
        
    }
}
