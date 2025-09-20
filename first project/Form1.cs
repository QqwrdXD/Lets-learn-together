using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to the foreign app \n    language learning app \n       Lets learn together";
        }

        private void showinfbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Let's Learn Together is an innovative educational application designed for learning foreign languages through an engaging and interactive game-based format that transforms the learning process into an exciting adventure. It is ideal for users of all ages and proficiency \nlevels — from absolute beginners taking their first steps in a new language to advanced learners seeking to improve their fluency and conversational skills. The app offers a comprehensive and immersive experience that makes language acquisition both effective and enjoyable.", "About app", MessageBoxButtons.OK);
        }

        private void aboutdevsbutton_Click(object sender, EventArgs e)
        {
            AboutdevsForm newForm = new AboutdevsForm();
            newForm.Show();
        }

        private void startgamebutton_Click(object sender, EventArgs e)
        {
            StartGameForm newForm = new StartGameForm();
            newForm.Show();
        }

    }

}
