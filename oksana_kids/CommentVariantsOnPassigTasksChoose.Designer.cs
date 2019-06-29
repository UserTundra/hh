namespace oksana_kids
{
    partial class CommentVariantsOnPassigTasksChoose
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
            this.T09_comment_variants_choose = new System.Windows.Forms.DataGridView();
            this.t09viewcommentvariantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet61 = new oksana_kids.bd_kidsDataSet61();
            this.t09_view_comment_variantsTableAdapter = new oksana_kids.bd_kidsDataSet61TableAdapters.T09_view_comment_variantsTableAdapter();
            this.T09commentChoose = new System.Windows.Forms.Button();
            this.nameplayresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isavtrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.T09_comment_variants_choose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t09viewcommentvariantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet61)).BeginInit();
            this.SuspendLayout();
            // 
            // T09_comment_variants_choose
            // 
            this.T09_comment_variants_choose.AutoGenerateColumns = false;
            this.T09_comment_variants_choose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.T09_comment_variants_choose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T09_comment_variants_choose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameplayresultDataGridViewTextBoxColumn,
            this.isavtrackDataGridViewTextBoxColumn,
            this.filelocationDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idcommentDataGridViewTextBoxColumn});
            this.T09_comment_variants_choose.DataSource = this.t09viewcommentvariantsBindingSource;
            this.T09_comment_variants_choose.Location = new System.Drawing.Point(12, 12);
            this.T09_comment_variants_choose.Name = "T09_comment_variants_choose";
            this.T09_comment_variants_choose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.T09_comment_variants_choose.Size = new System.Drawing.Size(654, 263);
            this.T09_comment_variants_choose.TabIndex = 0;
            this.T09_comment_variants_choose.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.T09_comment_variants_choose_CellClick);
            // 
            // t09viewcommentvariantsBindingSource
            // 
            this.t09viewcommentvariantsBindingSource.DataMember = "T09_view_comment_variants";
            this.t09viewcommentvariantsBindingSource.DataSource = this.bd_kidsDataSet61;
            // 
            // bd_kidsDataSet61
            // 
            this.bd_kidsDataSet61.DataSetName = "bd_kidsDataSet61";
            this.bd_kidsDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t09_view_comment_variantsTableAdapter
            // 
            this.t09_view_comment_variantsTableAdapter.ClearBeforeFill = true;
            // 
            // T09commentChoose
            // 
            this.T09commentChoose.Location = new System.Drawing.Point(591, 281);
            this.T09commentChoose.Name = "T09commentChoose";
            this.T09commentChoose.Size = new System.Drawing.Size(75, 23);
            this.T09commentChoose.TabIndex = 1;
            this.T09commentChoose.Text = "Выбрать";
            this.T09commentChoose.UseVisualStyleBackColor = true;
            this.T09commentChoose.Click += new System.EventHandler(this.T09commentChoose_Click);
            // 
            // nameplayresultDataGridViewTextBoxColumn
            // 
            this.nameplayresultDataGridViewTextBoxColumn.DataPropertyName = "name_play_result";
            this.nameplayresultDataGridViewTextBoxColumn.HeaderText = "Тип воспроизведения результата";
            this.nameplayresultDataGridViewTextBoxColumn.Name = "nameplayresultDataGridViewTextBoxColumn";
            // 
            // isavtrackDataGridViewTextBoxColumn
            // 
            this.isavtrackDataGridViewTextBoxColumn.DataPropertyName = "is_av_track";
            this.isavtrackDataGridViewTextBoxColumn.HeaderText = "Файл-сопровождение";
            this.isavtrackDataGridViewTextBoxColumn.Name = "isavtrackDataGridViewTextBoxColumn";
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
            // idcommentDataGridViewTextBoxColumn
            // 
            this.idcommentDataGridViewTextBoxColumn.DataPropertyName = "id_comment";
            this.idcommentDataGridViewTextBoxColumn.HeaderText = "id_comment";
            this.idcommentDataGridViewTextBoxColumn.Name = "idcommentDataGridViewTextBoxColumn";
            this.idcommentDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommentVariantsOnPassigTasksChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 312);
            this.Controls.Add(this.T09commentChoose);
            this.Controls.Add(this.T09_comment_variants_choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CommentVariantsOnPassigTasksChoose";
            this.Text = "Выбрать комментарий по результату выполнения тестового задания";
            this.Load += new System.EventHandler(this.CommentVariantsOnPassigTasksChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T09_comment_variants_choose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t09viewcommentvariantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet61)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView T09_comment_variants_choose;
        private bd_kidsDataSet61 bd_kidsDataSet61;
        private System.Windows.Forms.BindingSource t09viewcommentvariantsBindingSource;
        private bd_kidsDataSet61TableAdapters.T09_view_comment_variantsTableAdapter t09_view_comment_variantsTableAdapter;
        private System.Windows.Forms.Button T09commentChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameplayresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isavtrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcommentDataGridViewTextBoxColumn;
    }
}