namespace oksana_kids
{
    partial class TestTasksToStudySubjectsBind
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
            this.B04changeButton = new System.Windows.Forms.Button();
            this.B04deleteButton = new System.Windows.Forms.Button();
            this.B04 = new System.Windows.Forms.DataGridView();
            this.B04_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B04_equvivalent_perc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.B04addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B04_list_subjects = new System.Windows.Forms.ComboBox();
            this.r09studysubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet33 = new oksana_kids.bd_kidsDataSet33();
            this.T04 = new System.Windows.Forms.DataGridView();
            this.r09_study_subjectsTableAdapter = new oksana_kids.bd_kidsDataSet33TableAdapters.R09_study_subjectsTableAdapter();
            this.bd_kidsDataSet34 = new oksana_kids.bd_kidsDataSet34();
            this.b04bindviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b04_bind_viewTableAdapter = new oksana_kids.bd_kidsDataSet34TableAdapters.B04_bind_viewTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codesubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equvivalentpercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_kidsDataSet35 = new oksana_kids.bd_kidsDataSet35();
            this.t04viewtestingtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t04_view_testing_tasksTableAdapter = new oksana_kids.bd_kidsDataSet35TableAdapters.T04_view_testing_tasksTableAdapter();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.B04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r09studysubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b04bindviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t04viewtestingtasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // B04changeButton
            // 
            this.B04changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B04changeButton.Location = new System.Drawing.Point(352, 388);
            this.B04changeButton.Name = "B04changeButton";
            this.B04changeButton.Size = new System.Drawing.Size(123, 47);
            this.B04changeButton.TabIndex = 55;
            this.B04changeButton.Text = "Изменить";
            this.B04changeButton.UseVisualStyleBackColor = true;
            this.B04changeButton.Click += new System.EventHandler(this.B04changeButton_Click);
            // 
            // B04deleteButton
            // 
            this.B04deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B04deleteButton.Location = new System.Drawing.Point(513, 388);
            this.B04deleteButton.Name = "B04deleteButton";
            this.B04deleteButton.Size = new System.Drawing.Size(123, 47);
            this.B04deleteButton.TabIndex = 56;
            this.B04deleteButton.Text = "Удалить";
            this.B04deleteButton.UseVisualStyleBackColor = true;
            this.B04deleteButton.Click += new System.EventHandler(this.B04deleteButton_Click);
            // 
            // B04
            // 
            this.B04.AutoGenerateColumns = false;
            this.B04.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B04.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B04.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codesubjectDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.equvivalentpercDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.B04.DataSource = this.b04bindviewBindingSource;
            this.B04.Location = new System.Drawing.Point(10, 198);
            this.B04.Name = "B04";
            this.B04.Size = new System.Drawing.Size(626, 181);
            this.B04.TabIndex = 54;
            this.B04.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B04_CellClick);
            // 
            // B04_note
            // 
            this.B04_note.Location = new System.Drawing.Point(112, 98);
            this.B04_note.Multiline = true;
            this.B04_note.Name = "B04_note";
            this.B04_note.Size = new System.Drawing.Size(214, 34);
            this.B04_note.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Примечание";
            // 
            // B04_equvivalent_perc
            // 
            this.B04_equvivalent_perc.Location = new System.Drawing.Point(237, 62);
            this.B04_equvivalent_perc.Multiline = true;
            this.B04_equvivalent_perc.Name = "B04_equvivalent_perc";
            this.B04_equvivalent_perc.Size = new System.Drawing.Size(89, 20);
            this.B04_equvivalent_perc.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(10, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 32);
            this.label17.TabIndex = 50;
            this.label17.Text = "Процент соответствия ТЗ \r\nучебной теме";
            // 
            // B04addButton
            // 
            this.B04addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B04addButton.Location = new System.Drawing.Point(203, 141);
            this.B04addButton.Name = "B04addButton";
            this.B04addButton.Size = new System.Drawing.Size(123, 47);
            this.B04addButton.TabIndex = 49;
            this.B04addButton.Text = "Добавить";
            this.B04addButton.UseVisualStyleBackColor = true;
            this.B04addButton.Click += new System.EventHandler(this.B04addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Тестовые задания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Учебная тема";
            // 
            // B04_list_subjects
            // 
            this.B04_list_subjects.DataSource = this.r09studysubjectsBindingSource;
            this.B04_list_subjects.DisplayMember = "name_subject";
            this.B04_list_subjects.FormattingEnabled = true;
            this.B04_list_subjects.Location = new System.Drawing.Point(10, 28);
            this.B04_list_subjects.Name = "B04_list_subjects";
            this.B04_list_subjects.Size = new System.Drawing.Size(316, 21);
            this.B04_list_subjects.TabIndex = 45;
            this.B04_list_subjects.ValueMember = "code_subject";
            this.B04_list_subjects.SelectedIndexChanged += new System.EventHandler(this.B04_list_subjects_SelectedIndexChanged);
            // 
            // r09studysubjectsBindingSource
            // 
            this.r09studysubjectsBindingSource.DataMember = "R09_study_subjects";
            this.r09studysubjectsBindingSource.DataSource = this.bd_kidsDataSet33;
            // 
            // bd_kidsDataSet33
            // 
            this.bd_kidsDataSet33.DataSetName = "bd_kidsDataSet33";
            this.bd_kidsDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T04
            // 
            this.T04.AutoGenerateColumns = false;
            this.T04.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T04.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn1,
            this.fioDataGridViewTextBoxColumn,
            this.datecreateDataGridViewTextBoxColumn,
            this.datecorrectDataGridViewTextBoxColumn,
            this.nametypeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1});
            this.T04.DataSource = this.t04viewtestingtasksBindingSource;
            this.T04.Location = new System.Drawing.Point(332, 28);
            this.T04.Name = "T04";
            this.T04.Size = new System.Drawing.Size(304, 160);
            this.T04.TabIndex = 57;
            // 
            // r09_study_subjectsTableAdapter
            // 
            this.r09_study_subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet34
            // 
            this.bd_kidsDataSet34.DataSetName = "bd_kidsDataSet34";
            this.bd_kidsDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b04bindviewBindingSource
            // 
            this.b04bindviewBindingSource.DataMember = "B04_bind_view";
            this.b04bindviewBindingSource.DataSource = this.bd_kidsDataSet34;
            // 
            // b04_bind_viewTableAdapter
            // 
            this.b04_bind_viewTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codesubjectDataGridViewTextBoxColumn
            // 
            this.codesubjectDataGridViewTextBoxColumn.DataPropertyName = "code_subject";
            this.codesubjectDataGridViewTextBoxColumn.HeaderText = "code_subject";
            this.codesubjectDataGridViewTextBoxColumn.Name = "codesubjectDataGridViewTextBoxColumn";
            this.codesubjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Название ТЗ";
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            // 
            // equvivalentpercDataGridViewTextBoxColumn
            // 
            this.equvivalentpercDataGridViewTextBoxColumn.DataPropertyName = "equvivalent_perc";
            this.equvivalentpercDataGridViewTextBoxColumn.HeaderText = "Процент соответствия";
            this.equvivalentpercDataGridViewTextBoxColumn.Name = "equvivalentpercDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // bd_kidsDataSet35
            // 
            this.bd_kidsDataSet35.DataSetName = "bd_kidsDataSet35";
            this.bd_kidsDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t04viewtestingtasksBindingSource
            // 
            this.t04viewtestingtasksBindingSource.DataMember = "T04_view_testing_tasks";
            this.t04viewtestingtasksBindingSource.DataSource = this.bd_kidsDataSet35;
            // 
            // t04_view_testing_tasksTableAdapter
            // 
            this.t04_view_testing_tasksTableAdapter.ClearBeforeFill = true;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "id_task";
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametaskDataGridViewTextBoxColumn1
            // 
            this.nametaskDataGridViewTextBoxColumn1.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn1.HeaderText = "Название ТЗ";
            this.nametaskDataGridViewTextBoxColumn1.Name = "nametaskDataGridViewTextBoxColumn1";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Visible = false;
            // 
            // datecreateDataGridViewTextBoxColumn
            // 
            this.datecreateDataGridViewTextBoxColumn.DataPropertyName = "date_create";
            this.datecreateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.datecreateDataGridViewTextBoxColumn.Name = "datecreateDataGridViewTextBoxColumn";
            // 
            // datecorrectDataGridViewTextBoxColumn
            // 
            this.datecorrectDataGridViewTextBoxColumn.DataPropertyName = "date_correct";
            this.datecorrectDataGridViewTextBoxColumn.HeaderText = "date_correct";
            this.datecorrectDataGridViewTextBoxColumn.Name = "datecorrectDataGridViewTextBoxColumn";
            this.datecorrectDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametypeDataGridViewTextBoxColumn
            // 
            this.nametypeDataGridViewTextBoxColumn.DataPropertyName = "name_type";
            this.nametypeDataGridViewTextBoxColumn.HeaderText = "Тип ТЗ";
            this.nametypeDataGridViewTextBoxColumn.Name = "nametypeDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // TestTasksToStudySubjectsBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 444);
            this.Controls.Add(this.T04);
            this.Controls.Add(this.B04changeButton);
            this.Controls.Add(this.B04deleteButton);
            this.Controls.Add(this.B04);
            this.Controls.Add(this.B04_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B04_equvivalent_perc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.B04addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B04_list_subjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestTasksToStudySubjectsBind";
            this.Text = "Добавить тестовые задания к теме";
            this.Load += new System.EventHandler(this.TestTasksToStudySubjectsBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.B04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r09studysubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b04bindviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t04viewtestingtasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B04changeButton;
        private System.Windows.Forms.Button B04deleteButton;
        private System.Windows.Forms.DataGridView B04;
        private System.Windows.Forms.TextBox B04_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox B04_equvivalent_perc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button B04addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox B04_list_subjects;
        private System.Windows.Forms.DataGridView T04;
        private bd_kidsDataSet33 bd_kidsDataSet33;
        private System.Windows.Forms.BindingSource r09studysubjectsBindingSource;
        private bd_kidsDataSet33TableAdapters.R09_study_subjectsTableAdapter r09_study_subjectsTableAdapter;
        private bd_kidsDataSet34 bd_kidsDataSet34;
        private System.Windows.Forms.BindingSource b04bindviewBindingSource;
        private bd_kidsDataSet34TableAdapters.B04_bind_viewTableAdapter b04_bind_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codesubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equvivalentpercDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private bd_kidsDataSet35 bd_kidsDataSet35;
        private System.Windows.Forms.BindingSource t04viewtestingtasksBindingSource;
        private bd_kidsDataSet35TableAdapters.T04_view_testing_tasksTableAdapter t04_view_testing_tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecorrectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
    }
}