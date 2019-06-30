namespace oksana_kids
{
    partial class TestingTasksModulesToTestsBind
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
            this.label1 = new System.Windows.Forms.Label();
            this.B05_list_tests = new System.Windows.Forms.ComboBox();
            this.B05_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B05_serial_number_module = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.B05addButton = new System.Windows.Forms.Button();
            this.B05 = new System.Windows.Forms.DataGridView();
            this.B05changeButton = new System.Windows.Forms.Button();
            this.B05deleteButton = new System.Windows.Forms.Button();
            this.bd_kidsDataSet71 = new oksana_kids.bd_kidsDataSet71();
            this.t02testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t02_testsTableAdapter = new oksana_kids.bd_kidsDataSet71TableAdapters.T02_testsTableAdapter();
            this.bd_kidsDataSet72 = new oksana_kids.bd_kidsDataSet72();
            this.t03viewttmodulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t03_view_tt_modulesTableAdapter = new oksana_kids.bd_kidsDataSet72TableAdapters.T03_view_tt_modulesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.B05_list_modules = new System.Windows.Forms.ComboBox();
            this.bd_kidsDataSet73 = new oksana_kids.bd_kidsDataSet73();
            this.t03viewttmodulesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t03_view_tt_modulesTableAdapter1 = new oksana_kids.bd_kidsDataSet73TableAdapters.T03_view_tt_modulesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bd_kidsDataSet74 = new oksana_kids.bd_kidsDataSet74();
            this.b05viewttmodulestotestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b05_view_tt_modules_to_testsTableAdapter = new oksana_kids.bd_kidsDataSet74TableAdapters.B05_view_tt_modules_to_testsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumbermoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.B05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t03viewttmodulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t03viewttmodulesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b05viewttmodulestotestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Тест";
            // 
            // B05_list_tests
            // 
            this.B05_list_tests.DataSource = this.t02testsBindingSource;
            this.B05_list_tests.DisplayMember = "name_test";
            this.B05_list_tests.FormattingEnabled = true;
            this.B05_list_tests.Location = new System.Drawing.Point(15, 34);
            this.B05_list_tests.Name = "B05_list_tests";
            this.B05_list_tests.Size = new System.Drawing.Size(341, 21);
            this.B05_list_tests.TabIndex = 60;
            this.B05_list_tests.ValueMember = "id_test";
            this.B05_list_tests.SelectedIndexChanged += new System.EventHandler(this.B05_list_tests_SelectedIndexChanged);
            // 
            // B05_note
            // 
            this.B05_note.Location = new System.Drawing.Point(109, 87);
            this.B05_note.Multiline = true;
            this.B05_note.Name = "B05_note";
            this.B05_note.Size = new System.Drawing.Size(247, 20);
            this.B05_note.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Примечание";
            // 
            // B05_serial_number_module
            // 
            this.B05_serial_number_module.Location = new System.Drawing.Point(277, 61);
            this.B05_serial_number_module.Multiline = true;
            this.B05_serial_number_module.Name = "B05_serial_number_module";
            this.B05_serial_number_module.Size = new System.Drawing.Size(79, 20);
            this.B05_serial_number_module.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(253, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "Номер модуля спецификации в тесте";
            // 
            // B05addButton
            // 
            this.B05addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B05addButton.Location = new System.Drawing.Point(563, 62);
            this.B05addButton.Name = "B05addButton";
            this.B05addButton.Size = new System.Drawing.Size(123, 47);
            this.B05addButton.TabIndex = 63;
            this.B05addButton.Text = "Добавить";
            this.B05addButton.UseVisualStyleBackColor = true;
            this.B05addButton.Click += new System.EventHandler(this.B05addButton_Click);
            // 
            // B05
            // 
            this.B05.AutoGenerateColumns = false;
            this.B05.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B05.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B05.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idtestDataGridViewTextBoxColumn,
            this.serialnumbermoduleDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.B05.DataSource = this.b05viewttmodulestotestsBindingSource;
            this.B05.Location = new System.Drawing.Point(15, 115);
            this.B05.Name = "B05";
            this.B05.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.B05.Size = new System.Drawing.Size(671, 220);
            this.B05.TabIndex = 68;
            this.B05.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B05_CellClick);
            // 
            // B05changeButton
            // 
            this.B05changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B05changeButton.Location = new System.Drawing.Point(402, 341);
            this.B05changeButton.Name = "B05changeButton";
            this.B05changeButton.Size = new System.Drawing.Size(123, 47);
            this.B05changeButton.TabIndex = 69;
            this.B05changeButton.Text = "Изменить";
            this.B05changeButton.UseVisualStyleBackColor = true;
            this.B05changeButton.Click += new System.EventHandler(this.B05changeButton_Click);
            // 
            // B05deleteButton
            // 
            this.B05deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B05deleteButton.Location = new System.Drawing.Point(563, 341);
            this.B05deleteButton.Name = "B05deleteButton";
            this.B05deleteButton.Size = new System.Drawing.Size(123, 47);
            this.B05deleteButton.TabIndex = 70;
            this.B05deleteButton.Text = "Удалить";
            this.B05deleteButton.UseVisualStyleBackColor = true;
            this.B05deleteButton.Click += new System.EventHandler(this.B05deleteButton_Click);
            // 
            // bd_kidsDataSet71
            // 
            this.bd_kidsDataSet71.DataSetName = "bd_kidsDataSet71";
            this.bd_kidsDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t02testsBindingSource
            // 
            this.t02testsBindingSource.DataMember = "T02_tests";
            this.t02testsBindingSource.DataSource = this.bd_kidsDataSet71;
            // 
            // t02_testsTableAdapter
            // 
            this.t02_testsTableAdapter.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet72
            // 
            this.bd_kidsDataSet72.DataSetName = "bd_kidsDataSet72";
            this.bd_kidsDataSet72.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t03viewttmodulesBindingSource
            // 
            this.t03viewttmodulesBindingSource.DataMember = "T03_view_tt_modules";
            this.t03viewttmodulesBindingSource.DataSource = this.bd_kidsDataSet72;
            // 
            // t03_view_tt_modulesTableAdapter
            // 
            this.t03_view_tt_modulesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Модуль спецификации";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // B05_list_modules
            // 
            this.B05_list_modules.DataSource = this.t03viewttmodulesBindingSource1;
            this.B05_list_modules.DisplayMember = "name_task";
            this.B05_list_modules.FormattingEnabled = true;
            this.B05_list_modules.Location = new System.Drawing.Point(370, 35);
            this.B05_list_modules.Name = "B05_list_modules";
            this.B05_list_modules.Size = new System.Drawing.Size(316, 21);
            this.B05_list_modules.TabIndex = 72;
            this.B05_list_modules.ValueMember = "id_module";
            // 
            // bd_kidsDataSet73
            // 
            this.bd_kidsDataSet73.DataSetName = "bd_kidsDataSet73";
            this.bd_kidsDataSet73.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t03viewttmodulesBindingSource1
            // 
            this.t03viewttmodulesBindingSource1.DataMember = "T03_view_tt_modules";
            this.t03viewttmodulesBindingSource1.DataSource = this.bd_kidsDataSet73;
            // 
            // t03_view_tt_modulesTableAdapter1
            // 
            this.t03_view_tt_modulesTableAdapter1.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet74
            // 
            this.bd_kidsDataSet74.DataSetName = "bd_kidsDataSet74";
            this.bd_kidsDataSet74.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b05viewttmodulestotestsBindingSource
            // 
            this.b05viewttmodulestotestsBindingSource.DataMember = "B05_view_tt_modules_to_tests";
            this.b05viewttmodulestotestsBindingSource.DataSource = this.bd_kidsDataSet74;
            // 
            // b05_view_tt_modules_to_testsTableAdapter
            // 
            this.b05_view_tt_modules_to_testsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idtestDataGridViewTextBoxColumn
            // 
            this.idtestDataGridViewTextBoxColumn.DataPropertyName = "id_test";
            this.idtestDataGridViewTextBoxColumn.HeaderText = "id_test";
            this.idtestDataGridViewTextBoxColumn.Name = "idtestDataGridViewTextBoxColumn";
            this.idtestDataGridViewTextBoxColumn.Visible = false;
            // 
            // serialnumbermoduleDataGridViewTextBoxColumn
            // 
            this.serialnumbermoduleDataGridViewTextBoxColumn.DataPropertyName = "serial_number_module";
            this.serialnumbermoduleDataGridViewTextBoxColumn.HeaderText = "Порядковый номер модуля в тесте";
            this.serialnumbermoduleDataGridViewTextBoxColumn.Name = "serialnumbermoduleDataGridViewTextBoxColumn";
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Название модуля ТЗ";
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // TestingTasksModulesToTestsBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.B05_list_modules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B05changeButton);
            this.Controls.Add(this.B05deleteButton);
            this.Controls.Add(this.B05);
            this.Controls.Add(this.B05_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B05_serial_number_module);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.B05addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B05_list_tests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestingTasksModulesToTestsBind";
            this.Text = "Добавить модули спецификации ТЗ к тестам";
            this.Load += new System.EventHandler(this.TestingTasksModulesToTestsBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.B05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t03viewttmodulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t03viewttmodulesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b05viewttmodulestotestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox B05_list_tests;
        private System.Windows.Forms.TextBox B05_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox B05_serial_number_module;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button B05addButton;
        private System.Windows.Forms.DataGridView B05;
        private System.Windows.Forms.Button B05changeButton;
        private System.Windows.Forms.Button B05deleteButton;
        private bd_kidsDataSet71 bd_kidsDataSet71;
        private System.Windows.Forms.BindingSource t02testsBindingSource;
        private bd_kidsDataSet71TableAdapters.T02_testsTableAdapter t02_testsTableAdapter;
        private bd_kidsDataSet72 bd_kidsDataSet72;
        private System.Windows.Forms.BindingSource t03viewttmodulesBindingSource;
        private bd_kidsDataSet72TableAdapters.T03_view_tt_modulesTableAdapter t03_view_tt_modulesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox B05_list_modules;
        private bd_kidsDataSet73 bd_kidsDataSet73;
        private System.Windows.Forms.BindingSource t03viewttmodulesBindingSource1;
        private bd_kidsDataSet73TableAdapters.T03_view_tt_modulesTableAdapter t03_view_tt_modulesTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
        private bd_kidsDataSet74 bd_kidsDataSet74;
        private System.Windows.Forms.BindingSource b05viewttmodulestotestsBindingSource;
        private bd_kidsDataSet74TableAdapters.B05_view_tt_modules_to_testsTableAdapter b05_view_tt_modules_to_testsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumbermoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}