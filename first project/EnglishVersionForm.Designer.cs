namespace first_project
{
    partial class EnglishVersionForm
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
            this.englishanswerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEnglishWord = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // englishanswerbutton
            // 
            this.englishanswerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishanswerbutton.Location = new System.Drawing.Point(848, 677);
            this.englishanswerbutton.Name = "englishanswerbutton";
            this.englishanswerbutton.Size = new System.Drawing.Size(437, 125);
            this.englishanswerbutton.TabIndex = 0;
            this.englishanswerbutton.Text = "Answer";
            this.englishanswerbutton.UseVisualStyleBackColor = true;
            this.englishanswerbutton.Click += new System.EventHandler(this.englishanswerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(842, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your answer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(848, 582);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.AutoSize = true;
            this.lblEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnglishWord.Location = new System.Drawing.Point(679, 268);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(69, 54);
            this.lblEnglishWord.TabIndex = 3;
            this.lblEnglishWord.Text = "lbl";
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(514, 358);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(261, 22);
            this.txtTranslation.TabIndex = 4;
            // 
            // EnglishVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 893);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.lblEnglishWord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.englishanswerbutton);
            this.Name = "EnglishVersionForm";
            this.Text = "EnglishVersionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button englishanswerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEnglishWord;
        private System.Windows.Forms.TextBox txtTranslation;
    }
}