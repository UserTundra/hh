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
    public partial class Videos : Form
    {
        string video_path = "";
        string video_description = "";

        public Videos(string path, string description)
        {
            video_path = path;
            video_description = description;

            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            this.Text = video_description;
            //openFileDialog1.ShowDialog();
            //axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = video_path;
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
