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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.R07addButton = new System.Windows.Forms.Button();
            this.bd_kidsDataSet15 = new oksana_kids.bd_kidsDataSet15();
            this.r07methodicalmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r07_methodical_materialsTableAdapter = new oksana_kids.bd_kidsDataSet15TableAdapters.R07_methodical_materialsTableAdapter();
            this.idmethodmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_kidsDataSet16 = new oksana_kids.bd_kidsDataSet16();
            this.t02testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t02_testsTableAdapter = new oksana_kids.bd_kidsDataSet16TableAdapters.T02_testsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.t02testsBindingSource;
            this.comboBox1.DisplayMember = "name_test";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id_test";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmethodmaterialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.r07methodicalmaterialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
            this.dataGridView1.TabIndex = 16;
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
            // 
            // bd_kidsDataSet15
            // 
            this.bd_kidsDataSet15.DataSetName = "bd_kidsDataSet15";
            this.bd_kidsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r07methodicalmaterialsBindingSource
            // 
            this.r07methodicalmaterialsBindingSource.DataMember = "R07_methodical_materials";
            this.r07methodicalmaterialsBindingSource.DataSource = this.bd_kidsDataSet15;
            // 
            // r07_methodical_materialsTableAdapter
            // 
            this.r07_methodical_materialsTableAdapter.ClearBeforeFill = true;
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
            // bd_kidsDataSet16
            // 
            this.bd_kidsDataSet16.DataSetName = "bd_kidsDataSet16";
            this.bd_kidsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t02testsBindingSource
            // 
            this.t02testsBindingSource.DataMember = "T02_tests";
            this.t02testsBindingSource.DataSource = this.bd_kidsDataSet16;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MethodicalMaterialBind";
            this.Text = "Добавить методический материал к тесту";
            this.Load += new System.EventHandler(this.MethodicalMaterialBind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02testsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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