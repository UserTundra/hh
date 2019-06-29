using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string filePath;
        private string img_size = "";

        bd_kidsEntities1 bd = new bd_kidsEntities1();

        int id;

        private void OPF(TextBox name, string pattern)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                var match = Regex.Match(OPF.FileName, pattern).ToString();
                filePath = match.ToString();
                name.Clear();
                name.Text = filePath;
            }
        }

        private void Files_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet51.T06_teaching_materials". При необходимости она может быть перемещена или удалена.
            this.t06_teaching_materialsTableAdapter.Fill(this.bd_kidsDataSet51.T06_teaching_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet50.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter.Fill(this.bd_kidsDataSet50.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet49.T07_view_soundtracks". При необходимости она может быть перемещена или удалена.
            this.t07_view_soundtracksTableAdapter.Fill(this.bd_kidsDataSet49.T07_view_soundtracks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet48.R14_track_types". При необходимости она может быть перемещена или удалена.
            this.r14_track_typesTableAdapter.Fill(this.bd_kidsDataSet48.R14_track_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet47.T08_view_audio_video_tracks". При необходимости она может быть перемещена или удалена.
            this.t08_view_audio_video_tracksTableAdapter.Fill(this.bd_kidsDataSet47.T08_view_audio_video_tracks);
            tabControl1.SelectTab(tabIndex);
        }

        #region T08

        private void T08_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T08.CurrentRow.Cells[0].Value.ToString());
        }

        private void updateT08()
        {
            var data = bd.T08_audio_video_tracks.Join(
            bd.R14_track_types,
            x => x.code_type,
            y => y.code_type,
            (p, w) => new {
                p.id_av_track,
                p.name_av_track,
                w.name_type,
                p.author,
                p.duration_sec,
                p.source,
                p.image_size_pix,
                p.filesize,
                p.date_create,
                p.note
            });

            T08.DataSource = data.ToList();
        }

        private void T08_source_add_Click(object sender, EventArgs e)
        {
            OPF(T08_source, @"test{1}.*(.wav|mid|midi|mp3|avi|wma|wmv|3gp|mov|flv|asf|gif|mp4|mpeg|WAV|MID|MIDI|MP3|AVI|WMA|WMV|3GP|MOV|FLV|ASF|GIF|MP4|MPEG)");
        }

        private void T08_code_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(T08_code_type.SelectedValue.ToString()) == 1 || int.Parse(T08_code_type.SelectedValue.ToString()) == 3)
                {
                    T08_image_size_pix1.Enabled = true;
                    T08_image_size_pix2.Enabled = true;
                }
                else
                {
                    T08_image_size_pix1.Enabled = false;
                    T08_image_size_pix2.Enabled = false;
                }
            }
            catch(Exception ee) { }
        }

        private void T08addButton_Click(object sender, EventArgs e)
        {
            if (T08_name_av_track.Text == "" || T08_author.Text == "" || T08_duration_sec.Text == "" || T08_source.Text == "" || T08_image_size_pix1.Text == "" || T08_image_size_pix2.Text == "" || T08_filesize.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                img_size += T08_image_size_pix1 + "X" + T08_image_size_pix2;

                var person = new T08_audio_video_tracks()
                {
                    name_av_track = T08_name_av_track.Text,
                    code_type = int.Parse(T08_code_type.SelectedValue.ToString()),
                    author = T08_author.Text,
                    duration_sec = int.Parse(T08_duration_sec.Text),
                    source = filePath,
                    image_size_pix = img_size == "" ? " " : img_size,
                    filesize = int.Parse(T08_filesize.Text),
                    date_create = T08_date_create.Value.ToString("dd.MM.yyyy"),
                    note = T08_note.Text == "" ? " " : T08_note.Text
                };
                bd.T08_audio_video_tracks.Add(person);
                bd.SaveChanges();

            }

            T08_name_av_track.Clear();
            T08_author.Clear();
            T08_duration_sec.Clear();
            T08_source.Clear();
            T08_image_size_pix1.Clear();
            T08_image_size_pix2.Clear();
            T08_filesize.Clear();
            T08_note.Clear();            
        }

        private void T08changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.T08_audio_video_tracks.Where(x => x.id_av_track == id).FirstOrDefault();
            if (row == null) return;

            row.name_av_track = T08.CurrentRow.Cells[1].Value.ToString();
            row.author = T08.CurrentRow.Cells[3].Value.ToString();
            row.duration_sec = int.Parse(T08.CurrentRow.Cells[4].Value.ToString());
            row.source = T08.CurrentRow.Cells[5].Value.ToString();
            row.image_size_pix = T08.CurrentRow.Cells[6].Value.ToString();
            row.filesize = int.Parse(T08.CurrentRow.Cells[7].Value.ToString());
            row.date_create = T08.CurrentRow.Cells[8].Value.ToString();
            row.note = T08.CurrentRow.Cells[9].Value.ToString();

            bd.SaveChanges();
            updateT08();
        }

        private void T08deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.T08_audio_video_tracks.Where(x => x.id_av_track == id).FirstOrDefault();
            if (row == null) return;

            bd.T08_audio_video_tracks.Remove(row);
            bd.SaveChanges();

            updateT08();
        }

        #endregion

        #region T07

        private void T07_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T07.CurrentRow.Cells[5].Value.ToString());
        }

        private void updateT07()
        {
            var data = bd.T07_soundtracks.Join(
            bd.T01_personalities,
            x => x.id_announcer,
            y => y.id_person,
            (p, w) => new {
                p.id_track,
                p.name_track,
                p.duration_sec,
                fio = w.surname + " " + w.name.Substring(0, 1) + ". " + w.patronymic.Substring(0, 1) + ".",
                p.file_location,
                p.note
            });

            T07.DataSource = data.ToList();
        }

        private void T07_file_location_add_Click(object sender, EventArgs e)
        {
            OPF(T07_file_location, @"test{ 1}.*(.wav|aiff|ape|flac|mp3|ogg|alac|wma|aac|WAV|AIFF|APE|FLAC|MP3|OGG|ALAC|WMA|AAC)");
        }

        private void T07addButton_Click(object sender, EventArgs e)
        {
            if (T07_name_track.Text == "" || T07_duration_sec.Text == "" || T07_file_location.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new T07_soundtracks()
                {
                    name_track = T07_name_track.Text,
                    duration_sec = int.Parse(T07_duration_sec.Text),
                    id_announcer = int.Parse(T07_id_announcer.SelectedValue.ToString()),
                    file_location = filePath,
                    note = T07_note.Text == "" ? " " : T07_note.Text
                };
                bd.T07_soundtracks.Add(person);
                bd.SaveChanges();

            }

            T07_name_track.Clear();
            T07_duration_sec.Clear();
            T07_file_location.Clear();
            T07_note.Clear();

            updateT07();
        }

        private void T07changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.T07_soundtracks.Where(x => x.id_track == id).FirstOrDefault();
            if (row == null) return;

            row.name_track = T07.CurrentRow.Cells[0].Value.ToString();
            row.duration_sec = int.Parse(T07.CurrentRow.Cells[1].Value.ToString());
            row.file_location = T07.CurrentRow.Cells[3].Value.ToString();
            row.note = T07.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();
        }

        private void T07deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.T07_soundtracks.Where(x => x.id_track == id).FirstOrDefault();
            if (row == null) return;

            bd.T07_soundtracks.Remove(row);
            bd.SaveChanges();

            updateT07();
        }

        #endregion

        #region T06

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label18, "для дополнительного обучающего материала \nуказывайте в поле Примечание - доп.обучающий материал");
        }

        private void T06_file_location_add_Click(object sender, EventArgs e)
        {
            OPF(T06_file_location, @"test{1}.*(.raw|jpeg|jpg|tiff|psd|bmp|gif|png|RAW|JPEG|JPG|TIFF|PSD|BMP|GIF|PNG)");
        }

        private void T06_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(T06.CurrentRow.Cells[5].Value.ToString());
        }

        private void updateT06()
        {
            var data = bd.T06_teaching_materials.Select(x => new { x.id_teach_material, x.description, x.file_location, x.author, x.source, x.note });
            T06.DataSource = data.ToList();
        }

        private void T06addButton_Click(object sender, EventArgs e)
        {
            if (T06_description.Text == "" || T06_file_location.Text == "" || T06_author.Text == "" || T06_source.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                var person = new T06_teaching_materials()
                {
                    description = T06_description.Text,
                    file_location = filePath,
                    author = T06_author.Text,
                    source = T06_source.Text,
                    note = T06_note.Text == "" ? " " : T06_note.Text
                };
                bd.T06_teaching_materials.Add(person);
                bd.SaveChanges();

            }

            T06_description.Clear();
            T06_file_location.Clear();
            T06_author.Clear();
            T06_source.Clear();
            T06_note.Clear();

            updateT06();
        }

        private void T06changeButton_Click(object sender, EventArgs e)
        {
            var row = bd.T06_teaching_materials.Where(x => x.id_teach_material == id).FirstOrDefault();
            if (row == null) return;

            row.description = T06.CurrentRow.Cells[0].Value.ToString();
            row.file_location = T06.CurrentRow.Cells[1].Value.ToString();
            row.author = T06.CurrentRow.Cells[2].Value.ToString();
            row.source = T06.CurrentRow.Cells[3].Value.ToString();
            row.note = T06.CurrentRow.Cells[4].Value.ToString();

            bd.SaveChanges();

            updateT06();
        }

        private void T06deleteButton_Click(object sender, EventArgs e)
        {
            var row = bd.T06_teaching_materials.Where(x => x.id_teach_material == id).FirstOrDefault();
            if (row == null) return;

            bd.T06_teaching_materials.Remove(row);
            bd.SaveChanges();

            updateT06();
        }

        #endregion

      
    }
}
