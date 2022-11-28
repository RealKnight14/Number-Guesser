using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{


    public partial class frmnumber : Form
    {

        Random randomnumber = new Random();

        int number = 0;
        int guesses = 0;

        public frmnumber()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void lblthink_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;

            if (i == number)
            {
                MessageBox.Show("Nice, you guessed it. Try Another");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;

            }
            else if (i < number)
            {
                MessageBox.Show("Go Higher");
            }
            else
            {
                MessageBox.Show("Go Lower");


            }
        }


        private void loadQuestions()
        {
            number = randomnumber.Next(0, 10);

            lblthink.Text = "I am thinking of a number between 0 and 10";
        }
            
    }
}

