namespace oksana_kids
{
    partial class Files
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.T06_teaching_materials = new System.Windows.Forms.TabPage();
            this.T07_soundtracks = new System.Windows.Forms.TabPage();
            this.T08_audio_video_tracks = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.T08_audio_video_tracks);
            this.tabControl1.Controls.Add(this.T07_soundtracks);
            this.tabControl1.Controls.Add(this.T06_teaching_materials);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // T06_teaching_materials
            // 
            this.T06_teaching_materials.Location = new System.Drawing.Point(4, 22);
            this.T06_teaching_materials.Name = "T06_teaching_materials";
            this.T06_teaching_materials.Padding = new System.Windows.Forms.Padding(3);
            this.T06_teaching_materials.Size = new System.Drawing.Size(846, 376);
            this.T06_teaching_materials.TabIndex = 1;
            this.T06_teaching_materials.Text = "Обучающие материалы";
            this.T06_teaching_materials.UseVisualStyleBackColor = true;
            // 
            // T07_soundtracks
            // 
            this.T07_soundtracks.Location = new System.Drawing.Point(4, 22);
            this.T07_soundtracks.Name = "T07_soundtracks";
            this.T07_soundtracks.Padding = new System.Windows.Forms.Padding(3);
            this.T07_soundtracks.Size = new System.Drawing.Size(846, 376);
            this.T07_soundtracks.TabIndex = 2;
            this.T07_soundtracks.Text = "Звуковые сопровождения";
            this.T07_soundtracks.UseVisualStyleBackColor = true;
            // 
            // T08_audio_video_tracks
            // 
            this.T08_audio_video_tracks.Location = new System.Drawing.Point(4, 22);
            this.T08_audio_video_tracks.Name = "T08_audio_video_tracks";
            this.T08_audio_video_tracks.Padding = new System.Windows.Forms.Padding(3);
            this.T08_audio_video_tracks.Size = new System.Drawing.Size(846, 376);
            this.T08_audio_video_tracks.TabIndex = 3;
            this.T08_audio_video_tracks.Text = "Аудио/видео ролики";
            this.T08_audio_video_tracks.UseVisualStyleBackColor = true;
            // 
            // Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 417);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Files";
            this.Text = "Файлы";
            this.Load += new System.EventHandler(this.Files_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage T06_teaching_materials;
        private System.Windows.Forms.TabPage T07_soundtracks;
        private System.Windows.Forms.TabPage T08_audio_video_tracks;
    }
}