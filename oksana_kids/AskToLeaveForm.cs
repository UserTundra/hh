using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class AskToLeaveForm : Form
    {
        public AskToLeaveForm()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            setSpeech("да");
            Application.Exit();
        }

        private void no_Click(object sender, EventArgs e)
        {
            setSpeech("нет");
            this.Close();
        }

        public void setSpeech(string text)
        {
            SpeechSynthesizer speechSynth = new SpeechSynthesizer();

            speechSynth.Volume = 100;
            speechSynth.Speak(text);

            speechSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);

        }

        private void AskToLeaveForm_Load(object sender, EventArgs e)
        {
            setSpeech("Завершаешь работу");
        }
    }
}
