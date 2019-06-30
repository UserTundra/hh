namespace oksana_kids
{
    partial class AddAnswersToTasks
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
            this.T11_name_task = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T11_code_key_word = new System.Windows.Forms.ComboBox();
            this.T11_string_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T11_image_value = new System.Windows.Forms.TextBox();
            this.T11_sound_value = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.T11_grouping = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T11_group_no = new System.Windows.Forms.TextBox();
            this.T11 = new System.Windows.Forms.DataGridView();
            this.T11addButton = new System.Windows.Forms.Button();
            this.T11changeButton = new System.Windows.Forms.Button();
            this.T11deleteButton = new System.Windows.Forms.Button();
            this.T11_is_correct_yes = new System.Windows.Forms.RadioButton();
            this.T11_is_correct_no = new System.Windows.Forms.RadioButton();
            this.bd_kidsDataSet78 = new oksana_kids.bd_kidsDataSet78();
            this.r15taskkeywordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r15_task_key_wordsTableAdapter = new oksana_kids.bd_kidsDataSet78TableAdapters.R15_task_key_wordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r15taskkeywordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тестовое задание: ";
            // 
            // T11_name_task
            // 
            this.T11_name_task.AutoSize = true;
            this.T11_name_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11_name_task.Location = new System.Drawing.Point(144, 13);
            this.T11_name_task.Name = "T11_name_task";
            this.T11_name_task.Size = new System.Drawing.Size(45, 16);
            this.T11_name_task.TabIndex = 1;
            this.T11_name_task.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ключевое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Текстовое значение";
            // 
            // T11_code_key_word
            // 
            this.T11_code_key_word.DataSource = this.r15taskkeywordsBindingSource;
            this.T11_code_key_word.DisplayMember = "name_key_word";
            this.T11_code_key_word.FormattingEnabled = true;
            this.T11_code_key_word.Location = new System.Drawing.Point(139, 44);
            this.T11_code_key_word.Name = "T11_code_key_word";
            this.T11_code_key_word.Size = new System.Drawing.Size(173, 21);
            this.T11_code_key_word.TabIndex = 24;
            this.T11_code_key_word.ValueMember = "code_key_word";
            this.T11_code_key_word.SelectedIndexChanged += new System.EventHandler(this.T11_code_key_word_SelectedIndexChanged);
            // 
            // T11_string_value
            // 
            this.T11_string_value.Location = new System.Drawing.Point(168, 71);
            this.T11_string_value.Name = "T11_string_value";
            this.T11_string_value.Size = new System.Drawing.Size(144, 20);
            this.T11_string_value.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Картинка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // T11_image_value
            // 
            this.T11_image_value.Enabled = false;
            this.T11_image_value.Location = new System.Drawing.Point(168, 97);
            this.T11_image_value.Name = "T11_image_value";
            this.T11_image_value.Size = new System.Drawing.Size(144, 20);
            this.T11_image_value.TabIndex = 28;
            // 
            // T11_sound_value
            // 
            this.T11_sound_value.Enabled = false;
            this.T11_sound_value.Location = new System.Drawing.Point(168, 123);
            this.T11_sound_value.Name = "T11_sound_value";
            this.T11_sound_value.Size = new System.Drawing.Size(144, 20);
            this.T11_sound_value.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Звук";
            // 
            // T11_grouping
            // 
            this.T11_grouping.AutoSize = true;
            this.T11_grouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11_grouping.Location = new System.Drawing.Point(20, 150);
            this.T11_grouping.Name = "T11_grouping";
            this.T11_grouping.Size = new System.Drawing.Size(113, 20);
            this.T11_grouping.TabIndex = 34;
            this.T11_grouping.Text = "Группировка";
            this.T11_grouping.UseVisualStyleBackColor = true;
            this.T11_grouping.CheckedChanged += new System.EventHandler(this.T11_grouping_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Группа";
            // 
            // T11_group_no
            // 
            this.T11_group_no.Enabled = false;
            this.T11_group_no.Location = new System.Drawing.Point(206, 150);
            this.T11_group_no.Name = "T11_group_no";
            this.T11_group_no.Size = new System.Drawing.Size(106, 20);
            this.T11_group_no.TabIndex = 36;
            // 
            // T11
            // 
            this.T11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T11.Location = new System.Drawing.Point(318, 30);
            this.T11.Name = "T11";
            this.T11.Size = new System.Drawing.Size(553, 183);
            this.T11.TabIndex = 37;
            // 
            // T11addButton
            // 
            this.T11addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11addButton.Location = new System.Drawing.Point(490, 218);
            this.T11addButton.Name = "T11addButton";
            this.T11addButton.Size = new System.Drawing.Size(123, 47);
            this.T11addButton.TabIndex = 45;
            this.T11addButton.Text = "Добавить";
            this.T11addButton.UseVisualStyleBackColor = true;
            // 
            // T11changeButton
            // 
            this.T11changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11changeButton.Location = new System.Drawing.Point(619, 218);
            this.T11changeButton.Name = "T11changeButton";
            this.T11changeButton.Size = new System.Drawing.Size(123, 47);
            this.T11changeButton.TabIndex = 46;
            this.T11changeButton.Text = "Изменить";
            this.T11changeButton.UseVisualStyleBackColor = true;
            // 
            // T11deleteButton
            // 
            this.T11deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11deleteButton.Location = new System.Drawing.Point(748, 219);
            this.T11deleteButton.Name = "T11deleteButton";
            this.T11deleteButton.Size = new System.Drawing.Size(123, 47);
            this.T11deleteButton.TabIndex = 47;
            this.T11deleteButton.Text = "Удалить";
            this.T11deleteButton.UseVisualStyleBackColor = true;
            // 
            // T11_is_correct_yes
            // 
            this.T11_is_correct_yes.AutoSize = true;
            this.T11_is_correct_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11_is_correct_yes.Location = new System.Drawing.Point(20, 176);
            this.T11_is_correct_yes.Name = "T11_is_correct_yes";
            this.T11_is_correct_yes.Size = new System.Drawing.Size(137, 19);
            this.T11_is_correct_yes.TabIndex = 48;
            this.T11_is_correct_yes.TabStop = true;
            this.T11_is_correct_yes.Text = "Правильный ответ";
            this.T11_is_correct_yes.UseVisualStyleBackColor = true;
            // 
            // T11_is_correct_no
            // 
            this.T11_is_correct_no.AutoSize = true;
            this.T11_is_correct_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T11_is_correct_no.Location = new System.Drawing.Point(161, 176);
            this.T11_is_correct_no.Name = "T11_is_correct_no";
            this.T11_is_correct_no.Size = new System.Drawing.Size(151, 19);
            this.T11_is_correct_no.TabIndex = 49;
            this.T11_is_correct_no.TabStop = true;
            this.T11_is_correct_no.Text = "Неправильный ответ";
            this.T11_is_correct_no.UseVisualStyleBackColor = true;
            // 
            // bd_kidsDataSet78
            // 
            this.bd_kidsDataSet78.DataSetName = "bd_kidsDataSet78";
            this.bd_kidsDataSet78.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r15taskkeywordsBindingSource
            // 
            this.r15taskkeywordsBindingSource.DataMember = "R15_task_key_words";
            this.r15taskkeywordsBindingSource.DataSource = this.bd_kidsDataSet78;
            // 
            // r15_task_key_wordsTableAdapter
            // 
            this.r15_task_key_wordsTableAdapter.ClearBeforeFill = true;
            // 
            // AddAnswersToTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 274);
            this.Controls.Add(this.T11_is_correct_no);
            this.Controls.Add(this.T11_is_correct_yes);
            this.Controls.Add(this.T11addButton);
            this.Controls.Add(this.T11changeButton);
            this.Controls.Add(this.T11deleteButton);
            this.Controls.Add(this.T11);
            this.Controls.Add(this.T11_group_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T11_grouping);
            this.Controls.Add(this.T11_sound_value);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T11_image_value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T11_string_value);
            this.Controls.Add(this.T11_code_key_word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.T11_name_task);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAnswersToTasks";
            this.Text = "Добавить ответы к тестовому заданию";
            this.Load += new System.EventHandler(this.AddAnswersToTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r15taskkeywordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label T11_name_task;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox T11_code_key_word;
        private System.Windows.Forms.TextBox T11_string_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T11_image_value;
        private System.Windows.Forms.TextBox T11_sound_value;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox T11_grouping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T11_group_no;
        private System.Windows.Forms.DataGridView T11;
        private System.Windows.Forms.Button T11addButton;
        private System.Windows.Forms.Button T11changeButton;
        private System.Windows.Forms.Button T11deleteButton;
        private System.Windows.Forms.RadioButton T11_is_correct_yes;
        private System.Windows.Forms.RadioButton T11_is_correct_no;
        private bd_kidsDataSet78 bd_kidsDataSet78;
        private System.Windows.Forms.BindingSource r15taskkeywordsBindingSource;
        private bd_kidsDataSet78TableAdapters.R15_task_key_wordsTableAdapter r15_task_key_wordsTableAdapter;
    }
}