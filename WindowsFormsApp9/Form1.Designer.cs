namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.examCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.processButton = new System.Windows.Forms.Button();
            this.processListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // examCountNumericUpDown
            // 
            this.examCountNumericUpDown.Location = new System.Drawing.Point(12, 38);
            this.examCountNumericUpDown.Name = "examCountNumericUpDown";
            this.examCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.examCountNumericUpDown.TabIndex = 1;
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Location = new System.Drawing.Point(12, 64);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.Size = new System.Drawing.Size(240, 150);
            this.gradesDataGridView.TabIndex = 2;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(12, 220);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(109, 47);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "обработка результатов экзаменов";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // processListButton
            // 
            this.processListButton.Location = new System.Drawing.Point(146, 220);
            this.processListButton.Name = "processListButton";
            this.processListButton.Size = new System.Drawing.Size(94, 47);
            this.processListButton.TabIndex = 4;
            this.processListButton.Text = "обработка списка чисел";
            this.processListButton.UseVisualStyleBackColor = true;
            this.processListButton.Click += new System.EventHandler(this.ProcessListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 299);
            this.Controls.Add(this.processListButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.gradesDataGridView);
            this.Controls.Add(this.examCountNumericUpDown);
            this.Controls.Add(this.fullNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.examCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.NumericUpDown examCountNumericUpDown;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button processListButton;
    }
}
