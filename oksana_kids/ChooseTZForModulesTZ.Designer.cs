namespace oksana_kids
{
    partial class ChooseTZForModulesTZ
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
            this.T04_choose_TZ = new System.Windows.Forms.DataGridView();
            this.nameTZ = new System.Windows.Forms.TextBox();
            this.chooseTZ = new System.Windows.Forms.Button();
            this.bd_kidsDataSet59 = new oksana_kids.bd_kidsDataSet59();
            this.t04viewtestingtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t04_view_testing_tasksTableAdapter = new oksana_kids.bd_kidsDataSet59TableAdapters.T04_view_testing_tasksTableAdapter();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.T04_choose_TZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t04viewtestingtasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // T04_choose_TZ
            // 
            this.T04_choose_TZ.AutoGenerateColumns = false;
            this.T04_choose_TZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T04_choose_TZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.datecreateDataGridViewTextBoxColumn,
            this.datecorrectDataGridViewTextBoxColumn,
            this.nametypeDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.T04_choose_TZ.DataSource = this.t04viewtestingtasksBindingSource;
            this.T04_choose_TZ.Location = new System.Drawing.Point(12, 12);
            this.T04_choose_TZ.Name = "T04_choose_TZ";
            this.T04_choose_TZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.T04_choose_TZ.Size = new System.Drawing.Size(601, 268);
            this.T04_choose_TZ.TabIndex = 0;
            this.T04_choose_TZ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.T04_choose_TZ_CellClick);
            // 
            // nameTZ
            // 
            this.nameTZ.Enabled = false;
            this.nameTZ.Location = new System.Drawing.Point(13, 287);
            this.nameTZ.Name = "nameTZ";
            this.nameTZ.Size = new System.Drawing.Size(370, 20);
            this.nameTZ.TabIndex = 1;
            // 
            // chooseTZ
            // 
            this.chooseTZ.Location = new System.Drawing.Point(536, 287);
            this.chooseTZ.Name = "chooseTZ";
            this.chooseTZ.Size = new System.Drawing.Size(75, 23);
            this.chooseTZ.TabIndex = 2;
            this.chooseTZ.Text = "Выбрать";
            this.chooseTZ.UseVisualStyleBackColor = true;
            this.chooseTZ.Click += new System.EventHandler(this.chooseTZ_Click);
            // 
            // bd_kidsDataSet59
            // 
            this.bd_kidsDataSet59.DataSetName = "bd_kidsDataSet59";
            this.bd_kidsDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t04viewtestingtasksBindingSource
            // 
            this.t04viewtestingtasksBindingSource.DataMember = "T04_view_testing_tasks";
            this.t04viewtestingtasksBindingSource.DataSource = this.bd_kidsDataSet59;
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
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // datecreateDataGridViewTextBoxColumn
            // 
            this.datecreateDataGridViewTextBoxColumn.DataPropertyName = "date_create";
            this.datecreateDataGridViewTextBoxColumn.HeaderText = "Дата сощдания";
            this.datecreateDataGridViewTextBoxColumn.Name = "datecreateDataGridViewTextBoxColumn";
            // 
            // datecorrectDataGridViewTextBoxColumn
            // 
            this.datecorrectDataGridViewTextBoxColumn.DataPropertyName = "date_correct";
            this.datecorrectDataGridViewTextBoxColumn.HeaderText = "Дата корректировки";
            this.datecorrectDataGridViewTextBoxColumn.Name = "datecorrectDataGridViewTextBoxColumn";
            // 
            // nametypeDataGridViewTextBoxColumn
            // 
            this.nametypeDataGridViewTextBoxColumn.DataPropertyName = "name_type";
            this.nametypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.nametypeDataGridViewTextBoxColumn.Name = "nametypeDataGridViewTextBoxColumn";
            // 
            // filelocationDataGridViewTextBoxColumn
            // 
            this.filelocationDataGridViewTextBoxColumn.DataPropertyName = "file_location";
            this.filelocationDataGridViewTextBoxColumn.HeaderText = "file_location";
            this.filelocationDataGridViewTextBoxColumn.Name = "filelocationDataGridViewTextBoxColumn";
            this.filelocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // ChooseTZForModulesTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 320);
            this.Controls.Add(this.chooseTZ);
            this.Controls.Add(this.nameTZ);
            this.Controls.Add(this.T04_choose_TZ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseTZForModulesTZ";
            this.Text = "Выбрать тестовое задание для добавления модуля";
            this.Load += new System.EventHandler(this.ChooseTZForModulesTZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T04_choose_TZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t04viewtestingtasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView T04_choose_TZ;
        private System.Windows.Forms.TextBox nameTZ;
        private System.Windows.Forms.Button chooseTZ;
        private bd_kidsDataSet59 bd_kidsDataSet59;
        private System.Windows.Forms.BindingSource t04viewtestingtasksBindingSource;
        private bd_kidsDataSet59TableAdapters.T04_view_testing_tasksTableAdapter t04_view_testing_tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecorrectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}