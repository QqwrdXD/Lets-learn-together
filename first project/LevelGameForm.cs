using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class LevelGameForm: Form
    {
        public LevelGameForm()
        {
            InitializeComponent();
        }

        private void LevelGameForm_Load(object sender, EventArgs e)
        {

        }


        private void a2button_Click(object sender, EventArgs e)
        {
            EnglishVersionForm newForm = new EnglishVersionForm();
            newForm.Show();

        }

        private void b1button_Click(object sender, EventArgs e)
        {
            EnglishVersionFormB1 newForm = new EnglishVersionFormB1();
            newForm.Show();

        }

        private void b2button_Click(object sender, EventArgs e)
        {
            EnglishVersionFormB2 newForm = new EnglishVersionFormB2();
            newForm.Show();

        }
    }
}
