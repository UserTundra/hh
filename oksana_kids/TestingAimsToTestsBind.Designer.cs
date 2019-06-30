namespace oksana_kids
{
    partial class TestingAimsToTestsBind
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
            this.B01_list_aims = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B01_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.B01addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B01_list_tests = new System.Windows.Forms.ComboBox();
            this.B01_is_main_aim_yes = new System.Windows.Forms.RadioButton();
            this.B01_is_main_aim_no = new System.Windows.Forms.RadioButton();
            this.B01 = new System.Windows.Forms.DataGridView();
            this.B01changeButton = new System.Windows.Forms.Button();
            this.B01deleteButton = new System.Windows.Forms.Button();
            this.bd_kidsDataSet75 = new oksana_kids.bd_kidsDataSet75();
            this.b01viewtestingaimstotestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b01_view_testing_aims_to_testsTableAdapter = new oksana_kids.bd_kidsDataSet75TableAdapters.B01_view_testing_aims_to_testsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameaimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismainaimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_kidsDataSet76 = new oksana_kids.bd_kidsDataSet76();
            this.r06testingaimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r06_testing_aimsTableAdapter = new oksana_kids.bd_kidsDataSet76TableAdapters.R06_testing_aimsTableAdapter();
            this.bd_kidsDataSet77 = new oksana_kids.bd_kidsDataSet77();
            this.t02testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t02_testsTableAdapter = new oksana_kids.bd_kidsDataSet77TableAdapters.T02_testsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.B01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b01viewtestingaimstotestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r06testingaimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // B01_list_aims
            // 
            this.B01_list_aims.DataSource = this.r06testingaimsBindingSource;
            this.B01_list_aims.DisplayMember = "name_aim";
            this.B01_list_aims.FormattingEnabled = true;
            this.B01_list_aims.Location = new System.Drawing.Point(367, 33);
            this.B01_list_aims.Name = "B01_list_aims";
            this.B01_list_aims.Size = new System.Drawing.Size(316, 21);
            this.B01_list_aims.TabIndex = 81;
            this.B01_list_aims.ValueMember = "code_aim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Цели тестирования";
            // 
            // B01_note
            // 
            this.B01_note.Location = new System.Drawing.Point(106, 85);
            this.B01_note.Multiline = true;
            this.B01_note.Name = "B01_note";
            this.B01_note.Size = new System.Drawing.Size(247, 20);
            this.B01_note.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Примечание";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(9, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 76;
            this.label17.Text = "Основная цель";
            // 
            // B01addButton
            // 
            this.B01addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B01addButton.Location = new System.Drawing.Point(560, 60);
            this.B01addButton.Name = "B01addButton";
            this.B01addButton.Size = new System.Drawing.Size(123, 47);
            this.B01addButton.TabIndex = 75;
            this.B01addButton.Text = "Добавить";
            this.B01addButton.UseVisualStyleBackColor = true;
            this.B01addButton.Click += new System.EventHandler(this.B01addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Тест";
            // 
            // B01_list_tests
            // 
            this.B01_list_tests.DataSource = this.t02testsBindingSource;
            this.B01_list_tests.DisplayMember = "name_test";
            this.B01_list_tests.FormattingEnabled = true;
            this.B01_list_tests.Location = new System.Drawing.Point(12, 32);
            this.B01_list_tests.Name = "B01_list_tests";
            this.B01_list_tests.Size = new System.Drawing.Size(341, 21);
            this.B01_list_tests.TabIndex = 73;
            this.B01_list_tests.ValueMember = "id_test";
            this.B01_list_tests.SelectedIndexChanged += new System.EventHandler(this.B01_list_tests_SelectedIndexChanged);
            // 
            // B01_is_main_aim_yes
            // 
            this.B01_is_main_aim_yes.AutoSize = true;
            this.B01_is_main_aim_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B01_is_main_aim_yes.Location = new System.Drawing.Point(121, 60);
            this.B01_is_main_aim_yes.Name = "B01_is_main_aim_yes";
            this.B01_is_main_aim_yes.Size = new System.Drawing.Size(42, 20);
            this.B01_is_main_aim_yes.TabIndex = 82;
            this.B01_is_main_aim_yes.TabStop = true;
            this.B01_is_main_aim_yes.Text = "да";
            this.B01_is_main_aim_yes.UseVisualStyleBackColor = true;
            // 
            // B01_is_main_aim_no
            // 
            this.B01_is_main_aim_no.AutoSize = true;
            this.B01_is_main_aim_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B01_is_main_aim_no.Location = new System.Drawing.Point(169, 60);
            this.B01_is_main_aim_no.Name = "B01_is_main_aim_no";
            this.B01_is_main_aim_no.Size = new System.Drawing.Size(49, 20);
            this.B01_is_main_aim_no.TabIndex = 83;
            this.B01_is_main_aim_no.TabStop = true;
            this.B01_is_main_aim_no.Text = "нет";
            this.B01_is_main_aim_no.UseVisualStyleBackColor = true;
            // 
            // B01
            // 
            this.B01.AutoGenerateColumns = false;
            this.B01.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idtestDataGridViewTextBoxColumn,
            this.nameaimDataGridViewTextBoxColumn,
            this.ismainaimDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.B01.DataSource = this.b01viewtestingaimstotestsBindingSource;
            this.B01.Location = new System.Drawing.Point(14, 111);
            this.B01.Name = "B01";
            this.B01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.B01.Size = new System.Drawing.Size(669, 232);
            this.B01.TabIndex = 84;
            this.B01.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B01_CellClick);
            // 
            // B01changeButton
            // 
            this.B01changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B01changeButton.Location = new System.Drawing.Point(399, 349);
            this.B01changeButton.Name = "B01changeButton";
            this.B01changeButton.Size = new System.Drawing.Size(123, 47);
            this.B01changeButton.TabIndex = 85;
            this.B01changeButton.Text = "Изменить";
            this.B01changeButton.UseVisualStyleBackColor = true;
            this.B01changeButton.Click += new System.EventHandler(this.B01changeButton_Click);
            // 
            // B01deleteButton
            // 
            this.B01deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B01deleteButton.Location = new System.Drawing.Point(560, 349);
            this.B01deleteButton.Name = "B01deleteButton";
            this.B01deleteButton.Size = new System.Drawing.Size(123, 47);
            this.B01deleteButton.TabIndex = 86;
            this.B01deleteButton.Text = "Удалить";
            this.B01deleteButton.UseVisualStyleBackColor = true;
            // 
            // bd_kidsDataSet75
            // 
            this.bd_kidsDataSet75.DataSetName = "bd_kidsDataSet75";
            this.bd_kidsDataSet75.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b01viewtestingaimstotestsBindingSource
            // 
            this.b01viewtestingaimstotestsBindingSource.DataMember = "B01_view_testing_aims_to_tests";
            this.b01viewtestingaimstotestsBindingSource.DataSource = this.bd_kidsDataSet75;
            // 
            // b01_view_testing_aims_to_testsTableAdapter
            // 
            this.b01_view_testing_aims_to_testsTableAdapter.ClearBeforeFill = true;
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
            // nameaimDataGridViewTextBoxColumn
            // 
            this.nameaimDataGridViewTextBoxColumn.DataPropertyName = "name_aim";
            this.nameaimDataGridViewTextBoxColumn.HeaderText = "Цель";
            this.nameaimDataGridViewTextBoxColumn.Name = "nameaimDataGridViewTextBoxColumn";
            // 
            // ismainaimDataGridViewTextBoxColumn
            // 
            this.ismainaimDataGridViewTextBoxColumn.DataPropertyName = "is_main_aim";
            this.ismainaimDataGridViewTextBoxColumn.HeaderText = "Признак основной";
            this.ismainaimDataGridViewTextBoxColumn.Name = "ismainaimDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // bd_kidsDataSet76
            // 
            this.bd_kidsDataSet76.DataSetName = "bd_kidsDataSet76";
            this.bd_kidsDataSet76.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r06testingaimsBindingSource
            // 
            this.r06testingaimsBindingSource.DataMember = "R06_testing_aims";
            this.r06testingaimsBindingSource.DataSource = this.bd_kidsDataSet76;
            // 
            // r06_testing_aimsTableAdapter
            // 
            this.r06_testing_aimsTableAdapter.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet77
            // 
            this.bd_kidsDataSet77.DataSetName = "bd_kidsDataSet77";
            this.bd_kidsDataSet77.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t02testsBindingSource
            // 
            this.t02testsBindingSource.DataMember = "T02_tests";
            this.t02testsBindingSource.DataSource = this.bd_kidsDataSet77;
            // 
            // t02_testsTableAdapter
            // 
            this.t02_testsTableAdapter.ClearBeforeFill = true;
            // 
            // TestingAimsToTestsBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 408);
            this.Controls.Add(this.B01changeButton);
            this.Controls.Add(this.B01deleteButton);
            this.Controls.Add(this.B01);
            this.Controls.Add(this.B01_is_main_aim_no);
            this.Controls.Add(this.B01_is_main_aim_yes);
            this.Controls.Add(this.B01_list_aims);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B01_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.B01addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B01_list_tests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestingAimsToTestsBind";
            this.Text = "Добавить цели тестирования к тестам";
            this.Load += new System.EventHandler(this.TestingAimsToTestsBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.B01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b01viewtestingaimstotestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r06testingaimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox B01_list_aims;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox B01_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button B01addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox B01_list_tests;
        private System.Windows.Forms.RadioButton B01_is_main_aim_yes;
        private System.Windows.Forms.RadioButton B01_is_main_aim_no;
        private System.Windows.Forms.DataGridView B01;
        private System.Windows.Forms.Button B01changeButton;
        private System.Windows.Forms.Button B01deleteButton;
        private bd_kidsDataSet75 bd_kidsDataSet75;
        private System.Windows.Forms.BindingSource b01viewtestingaimstotestsBindingSource;
        private bd_kidsDataSet75TableAdapters.B01_view_testing_aims_to_testsTableAdapter b01_view_testing_aims_to_testsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismainaimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private bd_kidsDataSet76 bd_kidsDataSet76;
        private System.Windows.Forms.BindingSource r06testingaimsBindingSource;
        private bd_kidsDataSet76TableAdapters.R06_testing_aimsTableAdapter r06_testing_aimsTableAdapter;
        private bd_kidsDataSet77 bd_kidsDataSet77;
        private System.Windows.Forms.BindingSource t02testsBindingSource;
        private bd_kidsDataSet77TableAdapters.T02_testsTableAdapter t02_testsTableAdapter;
    }
}