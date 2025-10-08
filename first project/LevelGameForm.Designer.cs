namespace first_project
{
    partial class LevelGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a2button
            // 
            this.a2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2button.Location = new System.Drawing.Point(532, 478);
            this.a2button.Name = "a2button";
            this.a2button.Size = new System.Drawing.Size(354, 171);
            this.a2button.TabIndex = 0;
            this.a2button.Text = "A2";
            this.a2button.UseVisualStyleBackColor = true;
            this.a2button.Click += new System.EventHandler(this.a2button_Click);
            // 
            // b1button
            // 
            this.b1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1button.Location = new System.Drawing.Point(892, 478);
            this.b1button.Name = "b1button";
            this.b1button.Size = new System.Drawing.Size(354, 171);
            this.b1button.TabIndex = 1;
            this.b1button.Text = "B1";
            this.b1button.UseVisualStyleBackColor = true;
            this.b1button.Click += new System.EventHandler(this.b1button_Click);
            // 
            // b2button
            // 
            this.b2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2button.Location = new System.Drawing.Point(1252, 478);
            this.b2button.Name = "b2button";
            this.b2button.Size = new System.Drawing.Size(354, 171);
            this.b2button.TabIndex = 2;
            this.b2button.Text = "B2";
            this.b2button.UseVisualStyleBackColor = true;
            this.b2button.Click += new System.EventHandler(this.b2button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(576, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please, select a level of the game";
            // 
            // LevelGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 868);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b2button);
            this.Controls.Add(this.b1button);
            this.Controls.Add(this.a2button);
            this.Name = "LevelGameForm";
            this.Text = "LevelGameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LevelGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a2button;
        private System.Windows.Forms.Button b1button;
        private System.Windows.Forms.Button b2button;
        private System.Windows.Forms.Label label1;
    }
}