namespace oksana_kids
{
    partial class StudyCourcesToPupilsClassesBind
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
            this.components = new System.ComponentModel.Container();
            this.R02 = new System.Windows.Forms.DataGridView();
            this.codeclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyyearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r02pupilsclassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet36 = new oksana_kids.bd_kidsDataSet36();
            this.B02changeButton = new System.Windows.Forms.Button();
            this.B02deleteButton = new System.Windows.Forms.Button();
            this.B02 = new System.Windows.Forms.DataGridView();
            this.B02_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B02addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.R08_list_cources = new System.Windows.Forms.ComboBox();
            this.r02_pupils_classesTableAdapter = new oksana_kids.bd_kidsDataSet36TableAdapters.R02_pupils_classesTableAdapter();
            this.bd_kidsDataSet39 = new oksana_kids.bd_kidsDataSet39();
            this.b02bindviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b02_bind_viewTableAdapter1 = new oksana_kids.bd_kidsDataSet39TableAdapters.B02_bind_viewTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeclassDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_kidsDataSet40 = new oksana_kids.bd_kidsDataSet40();
            this.r08studycoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r08_study_coursesTableAdapter = new oksana_kids.bd_kidsDataSet40TableAdapters.R08_study_coursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.R02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r02pupilsclassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b02bindviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r08studycoursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // R02
            // 
            this.R02.AutoGenerateColumns = false;
            this.R02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.R02.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeclassDataGridViewTextBoxColumn,
            this.nameclassDataGridViewTextBoxColumn,
            this.studyyearsDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.R02.DataSource = this.r02pupilsclassesBindingSource;
            this.R02.Location = new System.Drawing.Point(6, 24);
            this.R02.Name = "R02";
            this.R02.Size = new System.Drawing.Size(304, 160);
            this.R02.TabIndex = 69;
            this.R02.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.R02_CellClick);
            // 
            // codeclassDataGridViewTextBoxColumn
            // 
            this.codeclassDataGridViewTextBoxColumn.DataPropertyName = "code_class";
            this.codeclassDataGridViewTextBoxColumn.HeaderText = "code_class";
            this.codeclassDataGridViewTextBoxColumn.Name = "codeclassDataGridViewTextBoxColumn";
            this.codeclassDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameclassDataGridViewTextBoxColumn
            // 
            this.nameclassDataGridViewTextBoxColumn.DataPropertyName = "name_class";
            this.nameclassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.nameclassDataGridViewTextBoxColumn.Name = "nameclassDataGridViewTextBoxColumn";
            // 
            // studyyearsDataGridViewTextBoxColumn
            // 
            this.studyyearsDataGridViewTextBoxColumn.DataPropertyName = "study_years";
            this.studyyearsDataGridViewTextBoxColumn.HeaderText = "Годы обучения";
            this.studyyearsDataGridViewTextBoxColumn.Name = "studyyearsDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // r02pupilsclassesBindingSource
            // 
            this.r02pupilsclassesBindingSource.DataMember = "R02_pupils_classes";
            this.r02pupilsclassesBindingSource.DataSource = this.bd_kidsDataSet36;
            // 
            // bd_kidsDataSet36
            // 
            this.bd_kidsDataSet36.DataSetName = "bd_kidsDataSet36";
            this.bd_kidsDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // B02changeButton
            // 
            this.B02changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B02changeButton.Location = new System.Drawing.Point(348, 390);
            this.B02changeButton.Name = "B02changeButton";
            this.B02changeButton.Size = new System.Drawing.Size(123, 47);
            this.B02changeButton.TabIndex = 67;
            this.B02changeButton.Text = "Изменить";
            this.B02changeButton.UseVisualStyleBackColor = true;
            this.B02changeButton.Click += new System.EventHandler(this.B02changeButton_Click);
            // 
            // B02deleteButton
            // 
            this.B02deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B02deleteButton.Location = new System.Drawing.Point(509, 390);
            this.B02deleteButton.Name = "B02deleteButton";
            this.B02deleteButton.Size = new System.Drawing.Size(123, 47);
            this.B02deleteButton.TabIndex = 68;
            this.B02deleteButton.Text = "Удалить";
            this.B02deleteButton.UseVisualStyleBackColor = true;
            this.B02deleteButton.Click += new System.EventHandler(this.B02deleteButton_Click);
            // 
            // B02
            // 
            this.B02.AutoGenerateColumns = false;
            this.B02.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B02.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeclassDataGridViewTextBoxColumn1,
            this.namecourseDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1});
            this.B02.DataSource = this.b02bindviewBindingSource;
            this.B02.Location = new System.Drawing.Point(6, 200);
            this.B02.Name = "B02";
            this.B02.Size = new System.Drawing.Size(626, 181);
            this.B02.TabIndex = 66;
            this.B02.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B02_CellClick);
            // 
            // B02_note
            // 
            this.B02_note.Location = new System.Drawing.Point(422, 55);
            this.B02_note.Multiline = true;
            this.B02_note.Name = "B02_note";
            this.B02_note.Size = new System.Drawing.Size(210, 34);
            this.B02_note.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(325, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Примечание";
            // 
            // B02addButton
            // 
            this.B02addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B02addButton.Location = new System.Drawing.Point(328, 105);
            this.B02addButton.Name = "B02addButton";
            this.B02addButton.Size = new System.Drawing.Size(123, 47);
            this.B02addButton.TabIndex = 61;
            this.B02addButton.Text = "Добавить";
            this.B02addButton.UseVisualStyleBackColor = true;
            this.B02addButton.Click += new System.EventHandler(this.B02addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Классы обучающихся";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Учебные курсы";
            // 
            // R08_list_cources
            // 
            this.R08_list_cources.DataSource = this.r08studycoursesBindingSource;
            this.R08_list_cources.DisplayMember = "name_course";
            this.R08_list_cources.FormattingEnabled = true;
            this.R08_list_cources.Location = new System.Drawing.Point(328, 28);
            this.R08_list_cources.Name = "R08_list_cources";
            this.R08_list_cources.Size = new System.Drawing.Size(304, 21);
            this.R08_list_cources.TabIndex = 58;
            this.R08_list_cources.ValueMember = "code_course";
            // 
            // r02_pupils_classesTableAdapter
            // 
            this.r02_pupils_classesTableAdapter.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet39
            // 
            this.bd_kidsDataSet39.DataSetName = "bd_kidsDataSet39";
            this.bd_kidsDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b02bindviewBindingSource
            // 
            this.b02bindviewBindingSource.DataMember = "B02_bind_view";
            this.b02bindviewBindingSource.DataSource = this.bd_kidsDataSet39;
            // 
            // b02_bind_viewTableAdapter1
            // 
            this.b02_bind_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeclassDataGridViewTextBoxColumn1
            // 
            this.codeclassDataGridViewTextBoxColumn1.DataPropertyName = "code_class";
            this.codeclassDataGridViewTextBoxColumn1.HeaderText = "code_class";
            this.codeclassDataGridViewTextBoxColumn1.Name = "codeclassDataGridViewTextBoxColumn1";
            this.codeclassDataGridViewTextBoxColumn1.Visible = false;
            // 
            // namecourseDataGridViewTextBoxColumn
            // 
            this.namecourseDataGridViewTextBoxColumn.DataPropertyName = "name_course";
            this.namecourseDataGridViewTextBoxColumn.HeaderText = "Название курса";
            this.namecourseDataGridViewTextBoxColumn.Name = "namecourseDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            // 
            // bd_kidsDataSet40
            // 
            this.bd_kidsDataSet40.DataSetName = "bd_kidsDataSet40";
            this.bd_kidsDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r08studycoursesBindingSource
            // 
            this.r08studycoursesBindingSource.DataMember = "R08_study_courses";
            this.r08studycoursesBindingSource.DataSource = this.bd_kidsDataSet40;
            // 
            // r08_study_coursesTableAdapter
            // 
            this.r08_study_coursesTableAdapter.ClearBeforeFill = true;
            // 
            // StudyCourcesToPupilsClassesBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 439);
            this.Controls.Add(this.R02);
            this.Controls.Add(this.B02changeButton);
            this.Controls.Add(this.B02deleteButton);
            this.Controls.Add(this.B02);
            this.Controls.Add(this.B02_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B02addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R08_list_cources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudyCourcesToPupilsClassesBind";
            this.Text = "Добавить учебные курсы к классам обучающихся";
            this.Load += new System.EventHandler(this.StudyCourcesToPupilsClassesBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r02pupilsclassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b02bindviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r08studycoursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView R02;
        private System.Windows.Forms.Button B02changeButton;
        private System.Windows.Forms.Button B02deleteButton;
        private System.Windows.Forms.DataGridView B02;
        private System.Windows.Forms.TextBox B02_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B02addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox R08_list_cources;
        private bd_kidsDataSet36 bd_kidsDataSet36;
        private System.Windows.Forms.BindingSource r02pupilsclassesBindingSource;
        private bd_kidsDataSet36TableAdapters.R02_pupils_classesTableAdapter r02_pupils_classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyyearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private bd_kidsDataSet39 bd_kidsDataSet39;
        private System.Windows.Forms.BindingSource b02bindviewBindingSource;
        private bd_kidsDataSet39TableAdapters.B02_bind_viewTableAdapter b02_bind_viewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclassDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private bd_kidsDataSet40 bd_kidsDataSet40;
        private System.Windows.Forms.BindingSource r08studycoursesBindingSource;
        private bd_kidsDataSet40TableAdapters.R08_study_coursesTableAdapter r08_study_coursesTableAdapter;
    }
}