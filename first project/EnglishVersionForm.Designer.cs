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
            this.txtEnglishAnswer = new System.Windows.Forms.TextBox();
            this.lblEnglishWord = new System.Windows.Forms.Label();
            this.beginnbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnglishResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // englishanswerbutton
            // 
            this.englishanswerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishanswerbutton.Location = new System.Drawing.Point(1005, 655);
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
            this.label1.Location = new System.Drawing.Point(796, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your answer";
            // 
            // txtEnglishAnswer
            // 
            this.txtEnglishAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnglishAnswer.Location = new System.Drawing.Point(802, 571);
            this.txtEnglishAnswer.Name = "txtEnglishAnswer";
            this.txtEnglishAnswer.Size = new System.Drawing.Size(398, 34);
            this.txtEnglishAnswer.TabIndex = 2;
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.AutoSize = true;
            this.lblEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnglishWord.Location = new System.Drawing.Point(793, 194);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(0, 54);
            this.lblEnglishWord.TabIndex = 3;
            // 
            // beginnbutton
            // 
            this.beginnbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginnbutton.Location = new System.Drawing.Point(801, 655);
            this.beginnbutton.Name = "beginnbutton";
            this.beginnbutton.Size = new System.Drawing.Size(198, 125);
            this.beginnbutton.TabIndex = 5;
            this.beginnbutton.Text = "Start";
            this.beginnbutton.UseVisualStyleBackColor = true;
            this.beginnbutton.Click += new System.EventHandler(this.beginnbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "P.s use \"_\" for button \"space\"";
            // 
            // lblEnglishResult
            // 
            this.lblEnglishResult.AutoSize = true;
            this.lblEnglishResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnglishResult.Location = new System.Drawing.Point(796, 306);
            this.lblEnglishResult.Name = "lblEnglishResult";
            this.lblEnglishResult.Size = new System.Drawing.Size(0, 32);
            this.lblEnglishResult.TabIndex = 7;
            // 
            // EnglishVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 893);
            this.Controls.Add(this.lblEnglishResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beginnbutton);
            this.Controls.Add(this.lblEnglishWord);
            this.Controls.Add(this.txtEnglishAnswer);
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
        private System.Windows.Forms.TextBox txtEnglishAnswer;
        private System.Windows.Forms.Label lblEnglishWord;
        private System.Windows.Forms.Button beginnbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnglishResult;
    }
}