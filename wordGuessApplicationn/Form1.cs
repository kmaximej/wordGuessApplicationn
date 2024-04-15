using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wordGuessApplicationn
{
    public partial class frmGuessWord : Form
    {
        private string wordGuess = "computer";
        private StringBuilder wrongGuess = new StringBuilder();

        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "c??????r";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.ToLower();
            if (guess == wordGuess)

            {
                label1.Text = "Correct answer: " + wordGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                listBox1.Items.Add(guess);
                MessageBox.Show(" Wrong guess! \n Try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
