using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class EnglishVersionForm : Form
    {
        public EnglishVersionForm()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private string currentCorrectAnswer = "";

        private void englishanswerbutton_Click(object sender, EventArgs e)
        {
            string englishanswer = txtEnglishAnswer.Text.Trim('"').Trim();
                if (englishanswer == currentCorrectAnswer)
                {
                    lblEnglishResult.Text = "Correct";
                    lblEnglishResult.ForeColor = Color.Green;
                }
                else
                {
                    lblEnglishResult.Text = $"Incorrect. Correct is:{currentCorrectAnswer}";
                    lblEnglishResult.ForeColor = Color.Red;
                }
        }

        private void beginnbutton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Ваня\Desktop\for Lets learn together.txt";
            try
            {
                string[] allLines = File.ReadAllLines(filePath);
                int randomIndex = random.Next(allLines.Length);
                string randomLine = allLines[randomIndex];
                string[] parts = randomLine.Split(';');
                if (parts.Length >= 2)
                {
                    lblEnglishWord.Text = parts[0].Trim('"').Trim();
                    currentCorrectAnswer = parts[1].Trim('"').Trim();
                    txtEnglishAnswer.Text = "";
                    lblEnglishResult.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Try again", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
