using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class EnglishVersionFormB1: Form
    {
        public EnglishVersionFormB1()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private string currentCorrectAnswer = "";
        List<string> b1List = new List<string>();
        private void beginnbuttonb1_Click(object sender, EventArgs e)
        {
            string filePath = "for Lets learn together.txt";
            try
            {
                string[] allLines = File.ReadAllLines(filePath);
                foreach (string fileline in allLines)
                {
                    string[] parts = fileline.Split(';');
                    if (parts.Length >= 3)
                    {
                        string lvl = parts[2].Trim('"').Trim();
                        if (lvl == "2")
                        {
                            b1List.Add(fileline);
                        }
                    }
                }
                int randomIndex = random.Next(b1List.Count);
                string randomLine = b1List[randomIndex];
                string[] selectedParts = randomLine.Split(';');
                if (selectedParts.Length >= 3)
                {
                    lblEnglishWord.Text = selectedParts[0].Trim('"').Trim();
                    currentCorrectAnswer = selectedParts[1].Trim('"').Trim();
                    txtEnglishAnswer.Text = "";
                    lblEnglishResult.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Try again", "Error", MessageBoxButtons.OK);
            }
        }

        private void englishanswerbuttonb1_Click(object sender, EventArgs e)
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
    }
}
