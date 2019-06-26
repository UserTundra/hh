namespace oksana_kids
{
    partial class MethodicalMaterialBind
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
            this.T02_name_test = new System.Windows.Forms.ComboBox();
            this.t02testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet16 = new oksana_kids.bd_kidsDataSet16();
            this.R07toT02 = new System.Windows.Forms.DataGridView();
            this.idmethodmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r07methodicalmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet15 = new oksana_kids.bd_kidsDataSet15();
            this.R07addButton = new System.Windows.Forms.Button();
            this.r07_methodical_materialsTableAdapter = new oksana_kids.bd_kidsDataSet15TableAdapters.R07_methodical_materialsTableAdapter();
            this.t02_testsTableAdapter = new oksana_kids.bd_kidsDataSet16TableAdapters.T02_testsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R07toT02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тест";
            // 
            // T02_name_test
            // 
            this.T02_name_test.DataSource = this.t02testsBindingSource;
            this.T02_name_test.DisplayMember = "name_test";
            this.T02_name_test.FormattingEnabled = true;
            this.T02_name_test.Location = new System.Drawing.Point(57, 8);
            this.T02_name_test.Name = "T02_name_test";
            this.T02_name_test.Size = new System.Drawing.Size(377, 21);
            this.T02_name_test.TabIndex = 15;
            this.T02_name_test.ValueMember = "id_test";
            // 
            // t02testsBindingSource
            // 
            this.t02testsBindingSource.DataMember = "T02_tests";
            this.t02testsBindingSource.DataSource = this.bd_kidsDataSet16;
            // 
            // bd_kidsDataSet16
            // 
            this.bd_kidsDataSet16.DataSetName = "bd_kidsDataSet16";
            this.bd_kidsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R07toT02
            // 
            this.R07toT02.AutoGenerateColumns = false;
            this.R07toT02.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.R07toT02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.R07toT02.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmethodmaterialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.R07toT02.DataSource = this.r07methodicalmaterialsBindingSource;
            this.R07toT02.Location = new System.Drawing.Point(15, 35);
            this.R07toT02.Name = "R07toT02";
            this.R07toT02.Size = new System.Drawing.Size(419, 150);
            this.R07toT02.TabIndex = 16;
            // 
            // idmethodmaterialDataGridViewTextBoxColumn
            // 
            this.idmethodmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_method_material";
            this.idmethodmaterialDataGridViewTextBoxColumn.HeaderText = "id_method_material";
            this.idmethodmaterialDataGridViewTextBoxColumn.Name = "idmethodmaterialDataGridViewTextBoxColumn";
            this.idmethodmaterialDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Методический материал";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
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
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Visible = false;
            // 
            // r07methodicalmaterialsBindingSource
            // 
            this.r07methodicalmaterialsBindingSource.DataMember = "R07_methodical_materials";
            this.r07methodicalmaterialsBindingSource.DataSource = this.bd_kidsDataSet15;
            // 
            // bd_kidsDataSet15
            // 
            this.bd_kidsDataSet15.DataSetName = "bd_kidsDataSet15";
            this.bd_kidsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R07addButton
            // 
            this.R07addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R07addButton.Location = new System.Drawing.Point(311, 191);
            this.R07addButton.Name = "R07addButton";
            this.R07addButton.Size = new System.Drawing.Size(123, 47);
            this.R07addButton.TabIndex = 20;
            this.R07addButton.Text = "Добавить";
            this.R07addButton.UseVisualStyleBackColor = true;
            this.R07addButton.Click += new System.EventHandler(this.R07addButton_Click);
            // 
            // r07_methodical_materialsTableAdapter
            // 
            this.r07_methodical_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // t02_testsTableAdapter
            // 
            this.t02_testsTableAdapter.ClearBeforeFill = true;
            // 
            // MethodicalMaterialBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 247);
            this.Controls.Add(this.R07addButton);
            this.Controls.Add(this.R07toT02);
            this.Controls.Add(this.T02_name_test);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MethodicalMaterialBind";
            this.Text = "Добавить методический материал к тесту";
            this.Load += new System.EventHandler(this.MethodicalMaterialBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R07toT02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox T02_name_test;
        private System.Windows.Forms.DataGridView R07toT02;
        private System.Windows.Forms.Button R07addButton;
        private bd_kidsDataSet15 bd_kidsDataSet15;
        private System.Windows.Forms.BindingSource r07methodicalmaterialsBindingSource;
        private bd_kidsDataSet15TableAdapters.R07_methodical_materialsTableAdapter r07_methodical_materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmethodmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private bd_kidsDataSet16 bd_kidsDataSet16;
        private System.Windows.Forms.BindingSource t02testsBindingSource;
        private bd_kidsDataSet16TableAdapters.T02_testsTableAdapter t02_testsTableAdapter;
    }
}