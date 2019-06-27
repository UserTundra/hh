namespace oksana_kids
{
    partial class StudySubjectsToCourcesBind
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
            this.B03_list_course = new System.Windows.Forms.ComboBox();
            this.r08studycoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet29 = new oksana_kids.bd_kidsDataSet29();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B03_list_subject = new System.Windows.Forms.ListBox();
            this.r09studysubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet28 = new oksana_kids.bd_kidsDataSet28();
            this.r09_study_subjectsTableAdapter = new oksana_kids.bd_kidsDataSet28TableAdapters.R09_study_subjectsTableAdapter();
            this.r08_study_coursesTableAdapter = new oksana_kids.bd_kidsDataSet29TableAdapters.R08_study_coursesTableAdapter();
            this.B03addButton = new System.Windows.Forms.Button();
            this.B03_serial_number_subject = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.B03_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B03 = new System.Windows.Forms.DataGridView();
            this.b03bindviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet30 = new oksana_kids.bd_kidsDataSet30();
            this.b03_bind_viewTableAdapter = new oksana_kids.bd_kidsDataSet30TableAdapters.B03_bind_viewTableAdapter();
            this.B03changeButton = new System.Windows.Forms.Button();
            this.B03deleteButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codecourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumbersubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.r08studycoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r09studysubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b03bindviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet30)).BeginInit();
            this.SuspendLayout();
            // 
            // B03_list_course
            // 
            this.B03_list_course.DataSource = this.r08studycoursesBindingSource;
            this.B03_list_course.DisplayMember = "name_course";
            this.B03_list_course.FormattingEnabled = true;
            this.B03_list_course.Location = new System.Drawing.Point(12, 28);
            this.B03_list_course.Name = "B03_list_course";
            this.B03_list_course.Size = new System.Drawing.Size(246, 21);
            this.B03_list_course.TabIndex = 0;
            this.B03_list_course.ValueMember = "code_course";
            this.B03_list_course.SelectedIndexChanged += new System.EventHandler(this.B03_list_course_SelectedIndexChanged);
            // 
            // r08studycoursesBindingSource
            // 
            this.r08studycoursesBindingSource.DataMember = "R08_study_courses";
            this.r08studycoursesBindingSource.DataSource = this.bd_kidsDataSet29;
            // 
            // bd_kidsDataSet29
            // 
            this.bd_kidsDataSet29.DataSetName = "bd_kidsDataSet29";
            this.bd_kidsDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Учебный курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Учебные темы";
            // 
            // B03_list_subject
            // 
            this.B03_list_subject.DataSource = this.r09studysubjectsBindingSource;
            this.B03_list_subject.DisplayMember = "name_subject";
            this.B03_list_subject.FormattingEnabled = true;
            this.B03_list_subject.Location = new System.Drawing.Point(264, 28);
            this.B03_list_subject.Name = "B03_list_subject";
            this.B03_list_subject.Size = new System.Drawing.Size(276, 147);
            this.B03_list_subject.TabIndex = 17;
            this.B03_list_subject.ValueMember = "code_subject";
            // 
            // r09studysubjectsBindingSource
            // 
            this.r09studysubjectsBindingSource.DataMember = "R09_study_subjects";
            this.r09studysubjectsBindingSource.DataSource = this.bd_kidsDataSet28;
            // 
            // bd_kidsDataSet28
            // 
            this.bd_kidsDataSet28.DataSetName = "bd_kidsDataSet28";
            this.bd_kidsDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r09_study_subjectsTableAdapter
            // 
            this.r09_study_subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // r08_study_coursesTableAdapter
            // 
            this.r08_study_coursesTableAdapter.ClearBeforeFill = true;
            // 
            // B03addButton
            // 
            this.B03addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B03addButton.Location = new System.Drawing.Point(135, 128);
            this.B03addButton.Name = "B03addButton";
            this.B03addButton.Size = new System.Drawing.Size(123, 47);
            this.B03addButton.TabIndex = 37;
            this.B03addButton.Text = "Добавить";
            this.B03addButton.UseVisualStyleBackColor = true;
            this.B03addButton.Click += new System.EventHandler(this.B03addButton_Click);
            // 
            // B03_serial_number_subject
            // 
            this.B03_serial_number_subject.Location = new System.Drawing.Point(179, 62);
            this.B03_serial_number_subject.Multiline = true;
            this.B03_serial_number_subject.Name = "B03_serial_number_subject";
            this.B03_serial_number_subject.Size = new System.Drawing.Size(79, 20);
            this.B03_serial_number_subject.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Номер темы в курсе";
            // 
            // B03_note
            // 
            this.B03_note.Location = new System.Drawing.Point(109, 88);
            this.B03_note.Multiline = true;
            this.B03_note.Name = "B03_note";
            this.B03_note.Size = new System.Drawing.Size(149, 34);
            this.B03_note.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Примечание";
            // 
            // B03
            // 
            this.B03.AutoGenerateColumns = false;
            this.B03.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B03.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B03.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codecourseDataGridViewTextBoxColumn,
            this.serialnumbersubjectDataGridViewTextBoxColumn,
            this.namesubjectDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.B03.DataSource = this.b03bindviewBindingSource;
            this.B03.Location = new System.Drawing.Point(12, 181);
            this.B03.Name = "B03";
            this.B03.Size = new System.Drawing.Size(528, 198);
            this.B03.TabIndex = 42;
            this.B03.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B03_CellClick);
            // 
            // b03bindviewBindingSource
            // 
            this.b03bindviewBindingSource.DataMember = "B03_bind_view";
            this.b03bindviewBindingSource.DataSource = this.bd_kidsDataSet30;
            // 
            // bd_kidsDataSet30
            // 
            this.bd_kidsDataSet30.DataSetName = "bd_kidsDataSet30";
            this.bd_kidsDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b03_bind_viewTableAdapter
            // 
            this.b03_bind_viewTableAdapter.ClearBeforeFill = true;
            // 
            // B03changeButton
            // 
            this.B03changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B03changeButton.Location = new System.Drawing.Point(256, 391);
            this.B03changeButton.Name = "B03changeButton";
            this.B03changeButton.Size = new System.Drawing.Size(123, 47);
            this.B03changeButton.TabIndex = 43;
            this.B03changeButton.Text = "Изменить";
            this.B03changeButton.UseVisualStyleBackColor = true;
            this.B03changeButton.Click += new System.EventHandler(this.B03changeButton_Click);
            // 
            // B03deleteButton
            // 
            this.B03deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B03deleteButton.Location = new System.Drawing.Point(417, 391);
            this.B03deleteButton.Name = "B03deleteButton";
            this.B03deleteButton.Size = new System.Drawing.Size(123, 47);
            this.B03deleteButton.TabIndex = 44;
            this.B03deleteButton.Text = "Удалить";
            this.B03deleteButton.UseVisualStyleBackColor = true;
            this.B03deleteButton.Click += new System.EventHandler(this.B03deleteButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codecourseDataGridViewTextBoxColumn
            // 
            this.codecourseDataGridViewTextBoxColumn.DataPropertyName = "code_course";
            this.codecourseDataGridViewTextBoxColumn.HeaderText = "code_course";
            this.codecourseDataGridViewTextBoxColumn.Name = "codecourseDataGridViewTextBoxColumn";
            this.codecourseDataGridViewTextBoxColumn.Visible = false;
            // 
            // serialnumbersubjectDataGridViewTextBoxColumn
            // 
            this.serialnumbersubjectDataGridViewTextBoxColumn.DataPropertyName = "serial_number_subject";
            this.serialnumbersubjectDataGridViewTextBoxColumn.HeaderText = "Номер темы в курсе";
            this.serialnumbersubjectDataGridViewTextBoxColumn.Name = "serialnumbersubjectDataGridViewTextBoxColumn";
            // 
            // namesubjectDataGridViewTextBoxColumn
            // 
            this.namesubjectDataGridViewTextBoxColumn.DataPropertyName = "name_subject";
            this.namesubjectDataGridViewTextBoxColumn.HeaderText = "Учебная тема";
            this.namesubjectDataGridViewTextBoxColumn.Name = "namesubjectDataGridViewTextBoxColumn";
            this.namesubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // StudySubjectsToCourcesBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 443);
            this.Controls.Add(this.B03changeButton);
            this.Controls.Add(this.B03deleteButton);
            this.Controls.Add(this.B03);
            this.Controls.Add(this.B03_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B03_serial_number_subject);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.B03addButton);
            this.Controls.Add(this.B03_list_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B03_list_course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudySubjectsToCourcesBind";
            this.Text = "Добавить учебные темы к курсам";
            this.Load += new System.EventHandler(this.StudySubjectsToCourcesBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.r08studycoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r09studysubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b03bindviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet30)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox B03_list_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox B03_list_subject;
        private bd_kidsDataSet28 bd_kidsDataSet28;
        private System.Windows.Forms.BindingSource r09studysubjectsBindingSource;
        private bd_kidsDataSet28TableAdapters.R09_study_subjectsTableAdapter r09_study_subjectsTableAdapter;
        private bd_kidsDataSet29 bd_kidsDataSet29;
        private System.Windows.Forms.BindingSource r08studycoursesBindingSource;
        private bd_kidsDataSet29TableAdapters.R08_study_coursesTableAdapter r08_study_coursesTableAdapter;
        private System.Windows.Forms.Button B03addButton;
        private System.Windows.Forms.TextBox B03_serial_number_subject;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox B03_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView B03;
        private bd_kidsDataSet30 bd_kidsDataSet30;
        private System.Windows.Forms.BindingSource b03bindviewBindingSource;
        private bd_kidsDataSet30TableAdapters.B03_bind_viewTableAdapter b03_bind_viewTableAdapter;
        private System.Windows.Forms.Button B03changeButton;
        private System.Windows.Forms.Button B03deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumbersubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}