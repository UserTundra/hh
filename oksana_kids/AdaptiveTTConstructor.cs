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
    public partial class AdaptiveTTConstructor : Form
    {
        public string name = "";

        bd_kidsEntities1 bd = new bd_kidsEntities1();
        public T04_testing_tasks testingTask;
        public AdaptiveTTConstructor(string taskName)
        {
            InitializeComponent();
            name = taskName;
            this.testingTask = bd.T04_testing_tasks.Where(x => x.name_task == taskName).FirstOrDefault();
            if (testingTask == null) { 
                MessageBox.Show("не выбран элемент");
                this.Close();
            }
        }

        private void AdaptiveTTConstructor_Load(object sender, EventArgs e)
        {
            selectedTT.Text = name;
            this.max_duration_testing.Text = testingTask.max_count_TT_try.ToString();
        }

        private void adaptiveTTAllConstructorGo_Click(object sender, EventArgs e)
        {
            try { 
                testingTask.max_count_TT_try = long.Parse(this.max_duration_testing.Text);
                bd.SaveChanges();
            }catch(Exception ee)
            {
                MessageBox.Show("неверное значение");
            }
        }

        private void adaptiveTT1ConstructorGo_Click(object sender, EventArgs e)
        {
            //testingTask.
        }
    }
}
