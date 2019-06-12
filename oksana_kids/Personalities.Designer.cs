namespace oksana_kids
{
    partial class Personalities
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
            this.gridViewPupils = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewOthers = new System.Windows.Forms.DataGridView();
            this.T01addButton = new System.Windows.Forms.Button();
            this.T01changeButton = new System.Windows.Forms.Button();
            this.T01deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.human_category = new System.Windows.Forms.ComboBox();
            this.study_class = new System.Windows.Forms.ComboBox();
            this.place_work_study = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.study_years = new System.Windows.Forms.TextBox();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPupils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOthers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewPupils
            // 
            this.gridViewPupils.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPupils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio});
            this.gridViewPupils.Location = new System.Drawing.Point(392, 40);
            this.gridViewPupils.Name = "gridViewPupils";
            this.gridViewPupils.Size = new System.Drawing.Size(596, 232);
            this.gridViewPupils.TabIndex = 0;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "Ф.И.О.";
            this.fio.Name = "fio";
            this.fio.Width = 68;
            // 
            // gridViewOthers
            // 
            this.gridViewOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOthers.Location = new System.Drawing.Point(392, 310);
            this.gridViewOthers.Name = "gridViewOthers";
            this.gridViewOthers.Size = new System.Drawing.Size(596, 240);
            this.gridViewOthers.TabIndex = 1;
            // 
            // T01addButton
            // 
            this.T01addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01addButton.Location = new System.Drawing.Point(263, 393);
            this.T01addButton.Name = "T01addButton";
            this.T01addButton.Size = new System.Drawing.Size(123, 47);
            this.T01addButton.TabIndex = 4;
            this.T01addButton.Text = "Добавить";
            this.T01addButton.UseVisualStyleBackColor = true;
            this.T01addButton.Click += new System.EventHandler(this.T01addButton_Click);
            // 
            // T01changeButton
            // 
            this.T01changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01changeButton.Location = new System.Drawing.Point(263, 446);
            this.T01changeButton.Name = "T01changeButton";
            this.T01changeButton.Size = new System.Drawing.Size(123, 47);
            this.T01changeButton.TabIndex = 5;
            this.T01changeButton.Text = "Изменить";
            this.T01changeButton.UseVisualStyleBackColor = true;
            // 
            // T01deleteButton
            // 
            this.T01deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01deleteButton.Location = new System.Drawing.Point(263, 499);
            this.T01deleteButton.Name = "T01deleteButton";
            this.T01deleteButton.Size = new System.Drawing.Size(123, 47);
            this.T01deleteButton.TabIndex = 6;
            this.T01deleteButton.Text = "Удалить";
            this.T01deleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(175, 14);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(211, 20);
            this.surname.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(175, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(211, 20);
            this.name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(175, 66);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(211, 20);
            this.patronymic.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Категория \r\nфизического лица";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Класс учащегося";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Место работы/учебы";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(175, 232);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(211, 20);
            this.login.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "login";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(175, 258);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 20);
            this.password.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "password";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(175, 284);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(211, 20);
            this.note.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Примечание";
            // 
            // human_category
            // 
            this.human_category.FormattingEnabled = true;
            this.human_category.Location = new System.Drawing.Point(175, 144);
            this.human_category.Name = "human_category";
            this.human_category.Size = new System.Drawing.Size(211, 21);
            this.human_category.TabIndex = 30;
            this.human_category.ValueMember = "code_category";
            this.human_category.TextChanged += new System.EventHandler(this.human_category_TextChanged);
            // 
            // study_class
            // 
            this.study_class.FormattingEnabled = true;
            this.study_class.Location = new System.Drawing.Point(175, 180);
            this.study_class.Name = "study_class";
            this.study_class.Size = new System.Drawing.Size(90, 21);
            this.study_class.TabIndex = 31;
            this.study_class.ValueMember = "code_class";
            this.study_class.SelectedIndexChanged += new System.EventHandler(this.study_class_SelectedIndexChanged);
            this.study_class.TextChanged += new System.EventHandler(this.study_class_TextChanged);
            // 
            // place_work_study
            // 
            this.place_work_study.FormattingEnabled = true;
            this.place_work_study.Location = new System.Drawing.Point(175, 206);
            this.place_work_study.Name = "place_work_study";
            this.place_work_study.Size = new System.Drawing.Size(211, 21);
            this.place_work_study.TabIndex = 32;
            this.place_work_study.ValueMember = "id_org";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(175, 118);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(211, 21);
            this.gender.TabIndex = 33;
            this.gender.ValueMember = "code_decode";
            // 
            // study_years
            // 
            this.study_years.Enabled = false;
            this.study_years.Location = new System.Drawing.Point(271, 180);
            this.study_years.Name = "study_years";
            this.study_years.Size = new System.Drawing.Size(115, 20);
            this.study_years.TabIndex = 34;
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(175, 92);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(211, 20);
            this.birth_date.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(392, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ученики";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(392, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Учителя";
            // 
            // Personalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.study_years);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.place_work_study);
            this.Controls.Add(this.study_class);
            this.Controls.Add(this.human_category);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T01addButton);
            this.Controls.Add(this.T01changeButton);
            this.Controls.Add(this.T01deleteButton);
            this.Controls.Add(this.gridViewOthers);
            this.Controls.Add(this.gridViewPupils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Personalities";
            this.Text = "Физические лица";
            this.Load += new System.EventHandler(this.Personalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPupils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOthers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewPupils;
        private System.Windows.Forms.DataGridView gridViewOthers;
        private System.Windows.Forms.Button T01addButton;
        private System.Windows.Forms.Button T01changeButton;
        private System.Windows.Forms.Button T01deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox human_category;
        private System.Windows.Forms.ComboBox study_class;
        private System.Windows.Forms.ComboBox place_work_study;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox study_years;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}