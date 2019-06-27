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
    public partial class Files : Form
    {
        public Files(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        public int tabIndex;

        private void Files_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabIndex);
        }
    }
}
