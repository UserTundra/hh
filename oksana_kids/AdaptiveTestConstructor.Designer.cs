namespace oksana_kids
{
    partial class AdaptiveTestConstructor
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
            this.selectedTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adaptiveTestConstructorGo = new System.Windows.Forms.Button();
            this.max_not_done_TT = new System.Windows.Forms.TextBox();
            this.max_duration_testing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max_TT_with_high_time_limit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectedTest
            // 
            this.selectedTest.AutoSize = true;
            this.selectedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedTest.Location = new System.Drawing.Point(150, 13);
            this.selectedTest.Name = "selectedTest";
            this.selectedTest.Size = new System.Drawing.Size(45, 16);
            this.selectedTest.TabIndex = 9;
            this.selectedTest.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбранный тест: ";
            // 
            // adaptiveTestConstructorGo
            // 
            this.adaptiveTestConstructorGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adaptiveTestConstructorGo.Location = new System.Drawing.Point(362, 176);
            this.adaptiveTestConstructorGo.Name = "adaptiveTestConstructorGo";
            this.adaptiveTestConstructorGo.Size = new System.Drawing.Size(123, 47);
            this.adaptiveTestConstructorGo.TabIndex = 7;
            this.adaptiveTestConstructorGo.Text = "Задать";
            this.adaptiveTestConstructorGo.UseVisualStyleBackColor = true;
            this.adaptiveTestConstructorGo.Click += new System.EventHandler(this.adaptiveTestConstructorGo_Click);
            // 
            // max_not_done_TT
            // 
            this.max_not_done_TT.Location = new System.Drawing.Point(395, 75);
            this.max_not_done_TT.Name = "max_not_done_TT";
            this.max_not_done_TT.Size = new System.Drawing.Size(90, 20);
            this.max_not_done_TT.TabIndex = 6;
            this.max_not_done_TT.TextChanged += new System.EventHandler(this.change_answer_numbers_TextChanged);
            // 
            // max_duration_testing
            // 
            this.max_duration_testing.Location = new System.Drawing.Point(395, 40);
            this.max_duration_testing.Name = "max_duration_testing";
            this.max_duration_testing.Size = new System.Drawing.Size(90, 20);
            this.max_duration_testing.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Максимальное количество НЕ сданных ТЗ с полностью \r\nиспользованными попытками";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимальная продолжительность тестирования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Максимальное количество ТЗ, по которым было \r\nпринудительное прерывание тестирова" +
    "ния из-за\r\nпревышения лимита по времени ТЗ";
            // 
            // max_TT_with_high_time_limit
            // 
            this.max_TT_with_high_time_limit.Location = new System.Drawing.Point(395, 123);
            this.max_TT_with_high_time_limit.Name = "max_TT_with_high_time_limit";
            this.max_TT_with_high_time_limit.Size = new System.Drawing.Size(90, 20);
            this.max_TT_with_high_time_limit.TabIndex = 11;
            // 
            // AdaptiveTestConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 233);
            this.Controls.Add(this.max_TT_with_high_time_limit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectedTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adaptiveTestConstructorGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.max_not_done_TT);
            this.Controls.Add(this.max_duration_testing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdaptiveTestConstructor";
            this.Text = "Конструктор параметров адаптивного теста в целом";
            this.Load += new System.EventHandler(this.AdaptiveTestConstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox max_not_done_TT;
        private System.Windows.Forms.TextBox max_duration_testing;
        private System.Windows.Forms.Button adaptiveTestConstructorGo;
        private System.Windows.Forms.Label selectedTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox max_TT_with_high_time_limit;
    }
}