
namespace Практика_15
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
            this.label1 = new System.Windows.Forms.Label();
            this.footTextBox = new System.Windows.Forms.TextBox();
            this.yardTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Футы";
            // 
            // footTextBox
            // 
            this.footTextBox.Location = new System.Drawing.Point(74, 133);
            this.footTextBox.Name = "footTextBox";
            this.footTextBox.Size = new System.Drawing.Size(179, 20);
            this.footTextBox.TabIndex = 1;
            // 
            // yardTextBox
            // 
            this.yardTextBox.Location = new System.Drawing.Point(413, 133);
            this.yardTextBox.Name = "yardTextBox";
            this.yardTextBox.Size = new System.Drawing.Size(188, 20);
            this.yardTextBox.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(292, 133);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "перевести";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(604, 234);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(67, 28);
            this.cleanButton.TabIndex = 4;
            this.cleanButton.Text = "очистить";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 28);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ярды";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.button);
            this.Controls.Add(this.yardTextBox);
            this.Controls.Add(this.footTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Переводчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox footTextBox;
        private System.Windows.Forms.TextBox yardTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
    }
}

