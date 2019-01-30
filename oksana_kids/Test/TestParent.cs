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
        List<SimplyTest> a;
        List<SimplyTest> b;
        PupilSelectionWindow callback;
        public int SummaryRightAnswers = 0;
        public TestParent(List<SimplyTest> a, List<SimplyTest> b, PupilSelectionWindow callback)
        {
            this.a = a;
            this.b = b;
            this.callback = callback;
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







            this.IsMdiContainer = true;
            TestForm first = new TestForm(a, this, this.Width,this.Height);
            first.MdiParent = this;
            first.Left = 0;
            first.Top = 0;
            first.Show();


        }
        public void ShowNext()
        {
            TestForm2 second = new TestForm2(b,callback,this);
            second.MdiParent = this;
            second.Left = 0;
            second.Top = 0;
            second.Show();
        }

        public void preClose()
        {
            MessageBox.Show("Тестирование окончено, верных ответов: " + this.SummaryRightAnswers);
            this.Hide();

        }
        
    }
}
