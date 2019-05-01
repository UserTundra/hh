namespace oksana_kids
{
    partial class MethodicalMaterials
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.T01addButton = new System.Windows.Forms.Button();
            this.T01changeButton = new System.Windows.Forms.Button();
            this.T01deleteButton = new System.Windows.Forms.Button();
            this.bd_kidsDataSet10 = new oksana_kids.bd_kidsDataSet10();
            this.r07methodicalmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r07_methodical_materialsTableAdapter = new oksana_kids.bd_kidsDataSet10TableAdapters.R07_methodical_materialsTableAdapter();
            this.idmethodmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmethodmaterialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.r07methodicalmaterialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(357, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(140, 94);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(211, 20);
            this.patronymic.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Примечание";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(140, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(211, 20);
            this.name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Источник";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(140, 18);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(211, 44);
            this.surname.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Описание";
            // 
            // T01addButton
            // 
            this.T01addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01addButton.Location = new System.Drawing.Point(228, 125);
            this.T01addButton.Name = "T01addButton";
            this.T01addButton.Size = new System.Drawing.Size(123, 47);
            this.T01addButton.TabIndex = 19;
            this.T01addButton.Text = "Добавить";
            this.T01addButton.UseVisualStyleBackColor = true;
            // 
            // T01changeButton
            // 
            this.T01changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01changeButton.Location = new System.Drawing.Point(228, 178);
            this.T01changeButton.Name = "T01changeButton";
            this.T01changeButton.Size = new System.Drawing.Size(123, 47);
            this.T01changeButton.TabIndex = 20;
            this.T01changeButton.Text = "Изменить";
            this.T01changeButton.UseVisualStyleBackColor = true;
            // 
            // T01deleteButton
            // 
            this.T01deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01deleteButton.Location = new System.Drawing.Point(228, 231);
            this.T01deleteButton.Name = "T01deleteButton";
            this.T01deleteButton.Size = new System.Drawing.Size(123, 47);
            this.T01deleteButton.TabIndex = 21;
            this.T01deleteButton.Text = "Удалить";
            this.T01deleteButton.UseVisualStyleBackColor = true;
            // 
            // bd_kidsDataSet10
            // 
            this.bd_kidsDataSet10.DataSetName = "bd_kidsDataSet10";
            this.bd_kidsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r07methodicalmaterialsBindingSource
            // 
            this.r07methodicalmaterialsBindingSource.DataMember = "R07_methodical_materials";
            this.r07methodicalmaterialsBindingSource.DataSource = this.bd_kidsDataSet10;
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
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // filelocationDataGridViewTextBoxColumn
            // 
            this.filelocationDataGridViewTextBoxColumn.DataPropertyName = "file_location";
            this.filelocationDataGridViewTextBoxColumn.HeaderText = "Источник";
            this.filelocationDataGridViewTextBoxColumn.Name = "filelocationDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // MethodicalMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 289);
            this.Controls.Add(this.T01addButton);
            this.Controls.Add(this.T01changeButton);
            this.Controls.Add(this.T01deleteButton);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MethodicalMaterials";
            this.Text = "Методические материалы";
            this.Load += new System.EventHandler(this.MethodicalMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r07methodicalmaterialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button T01addButton;
        private System.Windows.Forms.Button T01changeButton;
        private System.Windows.Forms.Button T01deleteButton;
        private bd_kidsDataSet10 bd_kidsDataSet10;
        private System.Windows.Forms.BindingSource r07methodicalmaterialsBindingSource;
        private bd_kidsDataSet10TableAdapters.R07_methodical_materialsTableAdapter r07_methodical_materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmethodmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}