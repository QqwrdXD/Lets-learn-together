namespace first_project
{
    partial class ChooseLevelForm
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
            this.a2button = new System.Windows.Forms.Button();
            this.b1button = new System.Windows.Forms.Button();
            this.b2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a2button
            // 
            this.a2button.Location = new System.Drawing.Point(85, 178);
            this.a2button.Name = "a2button";
            this.a2button.Size = new System.Drawing.Size(219, 107);
            this.a2button.TabIndex = 0;
            this.a2button.Text = "A2";
            this.a2button.UseVisualStyleBackColor = true;
            // 
            // b1button
            // 
            this.b1button.Location = new System.Drawing.Point(384, 178);
            this.b1button.Name = "b1button";
            this.b1button.Size = new System.Drawing.Size(216, 107);
            this.b1button.TabIndex = 1;
            this.b1button.Text = "B1";
            this.b1button.UseVisualStyleBackColor = true;
            // 
            // b2button
            // 
            this.b2button.Location = new System.Drawing.Point(215, 37);
            this.b2button.Name = "b2button";
            this.b2button.Size = new System.Drawing.Size(263, 112);
            this.b2button.TabIndex = 2;
            this.b2button.Text = "B2";
            this.b2button.UseVisualStyleBackColor = true;
            // 
            // ChooseLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b2button);
            this.Controls.Add(this.b1button);
            this.Controls.Add(this.a2button);
            this.Name = "ChooseLevelForm";
            this.Text = "ChooseLevelForm";
            this.Load += new System.EventHandler(this.ChooseLevelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button a2button;
        private System.Windows.Forms.Button b1button;
        private System.Windows.Forms.Button b2button;
    }
}