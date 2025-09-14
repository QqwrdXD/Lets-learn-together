namespace first_project
{
    partial class StartGameForm
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
            this.englishlanguagebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // englishlanguagebutton
            // 
            this.englishlanguagebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishlanguagebutton.Location = new System.Drawing.Point(806, 482);
            this.englishlanguagebutton.Name = "englishlanguagebutton";
            this.englishlanguagebutton.Size = new System.Drawing.Size(427, 143);
            this.englishlanguagebutton.TabIndex = 0;
            this.englishlanguagebutton.Text = "English";
            this.englishlanguagebutton.UseVisualStyleBackColor = true;
            this.englishlanguagebutton.Click += new System.EventHandler(this.englishlanguagebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(776, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the language";
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 893);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.englishlanguagebutton);
            this.Name = "StartGameForm";
            this.Text = "StartGameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button englishlanguagebutton;
        private System.Windows.Forms.Label label1;
    }
}