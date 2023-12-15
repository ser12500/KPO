namespace kursach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.myprogress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAR DEALERSHIP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myprogress
            // 
            this.myprogress.BackColor = System.Drawing.SystemColors.Desktop;
            this.myprogress.Controls.Add(this.Percentage);
            this.myprogress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.myprogress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myprogress.ForeColor = System.Drawing.Color.White;
            this.myprogress.Image = ((System.Drawing.Image)(resources.GetObject("myprogress.Image")));
            this.myprogress.Location = new System.Drawing.Point(83, 65);
            this.myprogress.Minimum = 0;
            this.myprogress.Name = "myprogress";
            this.myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myprogress.Size = new System.Drawing.Size(287, 287);
            this.myprogress.TabIndex = 3;
            this.myprogress.Text = "guna2CircleProgressBar1";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(140, 193);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(0, 28);
            this.Percentage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(472, 364);
            this.Controls.Add(this.myprogress);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.myprogress.ResumeLayout(false);
            this.myprogress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myprogress;
        private System.Windows.Forms.Label Percentage;
    }
}

