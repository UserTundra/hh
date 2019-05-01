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

        public AdaptiveTTConstructor(string taskName)
        {
            name = taskName;
            InitializeComponent();
        }

        private void AdaptiveTTConstructor_Load(object sender, EventArgs e)
        {
            selectedTT.Text = name;
        }
    }
}
