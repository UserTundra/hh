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
    public partial class Zoom : Form
    {
        public string t;
        public Func<int> callback;

        public Zoom(string text, Func<int> callback = null)
        {
            t = text;
            this.callback = callback;
            InitializeComponent();
        }

        private void Zoom_Load(object sender, EventArgs e)
        {
            zoomText.Text = t;
        }

        private void changeTextSize()
        {
            int size = trackText.Value;
            zoomText.Font = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
        }

        private void trackText_Scroll(object sender, EventArgs e)
        {
            changeTextSize();
        }

        private void Zoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.callback != null)
                this.callback.Invoke();
        }
    }
}
