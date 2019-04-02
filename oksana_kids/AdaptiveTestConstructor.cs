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
    public partial class AdaptiveTestConstructor : Form
    {
        public int try_number;
        public int change_number;
        public string name = "";


        public AdaptiveTestConstructor(string testName)
        {
            name = testName;
            InitializeComponent();
            
        }


        private void AdaptiveTestConstructor_Load(object sender, EventArgs e)
        {
            selectedTest.Text = name;
            
        }

        private void change_answer_numbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaptiveTestConstructorGo_Click(object sender, EventArgs e)
        {

        }
    }
}
