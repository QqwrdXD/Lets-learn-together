namespace first_project
{
    partial class MainForm
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
            this.showinfbutton = new System.Windows.Forms.Button();
            this.aboutdevsbutton = new System.Windows.Forms.Button();
            this.startgamebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showinfbutton
            // 
            this.showinfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showinfbutton.Location = new System.Drawing.Point(1287, 476);
            this.showinfbutton.Name = "showinfbutton";
            this.showinfbutton.Size = new System.Drawing.Size(427, 180);
            this.showinfbutton.TabIndex = 0;
            this.showinfbutton.Text = "About app";
            this.showinfbutton.UseVisualStyleBackColor = true;
            this.showinfbutton.Click += new System.EventHandler(this.showinfbutton_Click);
            // 
            // aboutdevsbutton
            // 
            this.aboutdevsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutdevsbutton.Location = new System.Drawing.Point(854, 476);
            this.aboutdevsbutton.Name = "aboutdevsbutton";
            this.aboutdevsbutton.Size = new System.Drawing.Size(427, 180);
            this.aboutdevsbutton.TabIndex = 1;
            this.aboutdevsbutton.Text = "About the Developers";
            this.aboutdevsbutton.UseVisualStyleBackColor = true;
            this.aboutdevsbutton.Click += new System.EventHandler(this.aboutdevsbutton_Click);
            // 
            // startgamebutton
            // 
            this.startgamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startgamebutton.Location = new System.Drawing.Point(421, 476);
            this.startgamebutton.Name = "startgamebutton";
            this.startgamebutton.Size = new System.Drawing.Size(427, 180);
            this.startgamebutton.TabIndex = 2;
            this.startgamebutton.Text = "Start game";
            this.startgamebutton.UseVisualStyleBackColor = true;
            this.startgamebutton.Click += new System.EventHandler(this.startgamebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(753, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "label 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 798);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startgamebutton);
            this.Controls.Add(this.aboutdevsbutton);
            this.Controls.Add(this.showinfbutton);
            this.Name = "MainForm";
            this.Text = "Lets learn together";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showinfbutton;
        private System.Windows.Forms.Button aboutdevsbutton;
        private System.Windows.Forms.Button startgamebutton;
        private System.Windows.Forms.Label label1;
    }
}

