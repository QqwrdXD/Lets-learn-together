using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace first_project
{
    public partial class EnglishVersionFormB2: Form
    {
        public EnglishVersionFormB2()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private string currentCorrectAnswer = "";
        List<string> b2List = new List<string>();
        private void beginnbuttonb2_Click(object sender, EventArgs e)
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
                        if (lvl == "3")
                        {
                            b2List.Add(fileline);
                        }
                    }
                }
                int randomIndex = random.Next(b2List.Count);
                string randomLine = b2List[randomIndex];
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

        private void englishanswerbuttonb2_Click(object sender, EventArgs e)
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
