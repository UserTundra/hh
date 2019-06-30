namespace oksana_kids
{
    partial class AdditionalTeachingMaterial
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
            this.additionalTM = new System.Windows.Forms.DataGridView();
            this.idteachmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t06viewteachingmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet52 = new oksana_kids.bd_kidsDataSet52();
            this.nameTM = new System.Windows.Forms.TextBox();
            this.chooseTeachingMaterial = new System.Windows.Forms.Button();
            this.t06_view_teaching_materialsTableAdapter = new oksana_kids.bd_kidsDataSet52TableAdapters.T06_view_teaching_materialsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.additionalTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t06viewteachingmaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet52)).BeginInit();
            this.SuspendLayout();
            // 
            // additionalTM
            // 
            this.additionalTM.AutoGenerateColumns = false;
            this.additionalTM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.additionalTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalTM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteachmaterialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.additionalTM.DataSource = this.t06viewteachingmaterialsBindingSource;
            this.additionalTM.Location = new System.Drawing.Point(12, 12);
            this.additionalTM.Name = "additionalTM";
            this.additionalTM.ReadOnly = true;
            this.additionalTM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.additionalTM.Size = new System.Drawing.Size(596, 260);
            this.additionalTM.TabIndex = 0;
            this.additionalTM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.additionalTM_CellClick);
            // 
            // idteachmaterialDataGridViewTextBoxColumn
            // 
            this.idteachmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_teach_material";
            this.idteachmaterialDataGridViewTextBoxColumn.HeaderText = "id_teach_material";
            this.idteachmaterialDataGridViewTextBoxColumn.Name = "idteachmaterialDataGridViewTextBoxColumn";
            this.idteachmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idteachmaterialDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filelocationDataGridViewTextBoxColumn
            // 
            this.filelocationDataGridViewTextBoxColumn.DataPropertyName = "file_location";
            this.filelocationDataGridViewTextBoxColumn.HeaderText = "file_location";
            this.filelocationDataGridViewTextBoxColumn.Name = "filelocationDataGridViewTextBoxColumn";
            this.filelocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.filelocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Источник";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t06viewteachingmaterialsBindingSource
            // 
            this.t06viewteachingmaterialsBindingSource.DataMember = "T06_view_teaching_materials";
            this.t06viewteachingmaterialsBindingSource.DataSource = this.bd_kidsDataSet52;
            // 
            // bd_kidsDataSet52
            // 
            this.bd_kidsDataSet52.DataSetName = "bd_kidsDataSet52";
            this.bd_kidsDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTM
            // 
            this.nameTM.Enabled = false;
            this.nameTM.Location = new System.Drawing.Point(12, 278);
            this.nameTM.Name = "nameTM";
            this.nameTM.Size = new System.Drawing.Size(367, 20);
            this.nameTM.TabIndex = 1;
            // 
            // chooseTeachingMaterial
            // 
            this.chooseTeachingMaterial.Location = new System.Drawing.Point(500, 276);
            this.chooseTeachingMaterial.Name = "chooseTeachingMaterial";
            this.chooseTeachingMaterial.Size = new System.Drawing.Size(107, 23);
            this.chooseTeachingMaterial.TabIndex = 2;
            this.chooseTeachingMaterial.Text = "Выбрать";
            this.chooseTeachingMaterial.UseVisualStyleBackColor = true;
            this.chooseTeachingMaterial.Click += new System.EventHandler(this.chooseTeachingMaterial_Click);
            // 
            // t06_view_teaching_materialsTableAdapter
            // 
            this.t06_view_teaching_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // AdditionalTeachingMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.Controls.Add(this.chooseTeachingMaterial);
            this.Controls.Add(this.nameTM);
            this.Controls.Add(this.additionalTM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdditionalTeachingMaterial";
            this.Text = "Дополнительный обучающий материал к тестам";
            this.Load += new System.EventHandler(this.AdditionalTeachingMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.additionalTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t06viewteachingmaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet52)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView additionalTM;
        private System.Windows.Forms.TextBox nameTM;
        private System.Windows.Forms.Button chooseTeachingMaterial;
        private bd_kidsDataSet52 bd_kidsDataSet52;
        private System.Windows.Forms.BindingSource t06viewteachingmaterialsBindingSource;
        private bd_kidsDataSet52TableAdapters.T06_view_teaching_materialsTableAdapter t06_view_teaching_materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteachmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}