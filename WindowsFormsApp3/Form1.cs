using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        /*variables for guesses count and new thread*/
        private int guesses = 1;
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        /*method for our buttom for the person setting the value to submit values*/
        private void submitValue_Click(object sender, EventArgs e)
        {
            //Hide the value from the guesser and set the box(s) to read only to be safe.
            inputBox.Hide();
            inputBox.ReadOnly = true;
            attemptsCount.ReadOnly = true;
        }

        /*guess button that will pass our values to the compare method and incriment the number of guesses on each click*/
        private void guessValue_Click(object sender, EventArgs e)
        {
            string guessValue = guessBox.Text;

            /*if the input passes validation pass to our compare method and incriment the guesses*/
            if (ValidateBoxes(inputBox.Text, guessBox.Text))
            {

                getComparison(inputBox.Text, guessBox.Text, guesses);
                guesses++;

                /*decrease the value shown in the attemptsallowedbox*/
                int decreaseattemptsCountBox = Convert.ToInt32(attemptsCount.Text) - 1;
                attemptsCount.Text = decreaseattemptsCountBox.ToString();
            }
            /*if we fail validation clear the box, dont incriment guesses or decrement the attempt box*/
            else
            {
                MessageBox.Show("Input must be the same size as the original value : {0}", inputBox.Text.Length.ToString());
                guessBox.Clear();
            }
        }

        /*method to compare our values and check the current guess count passed in */
        public void getComparison(string inputVal, string guessVal, int guessCount)
        {
            /*definging variables*/
            bool isMatch = guessBox.Text.Equals(inputBox.Text);
            int maxGuesses = Convert.ToInt32(attemptsCount.Text);
            int x = 0;
            int y = 0;
           
            /*if match call winCondition method*/
            if (isMatch == true)
            {
                winConditions(isMatch);  
            }
            /*if we never set isMatch to true and we exceed the amount of guesses allowed by the setting call loseConditions method*/
            else if (isMatch == false && guessCount > maxGuesses)
            {
                loseConditions();
            }
            /*while nieither of the above apply we will run two loops over the strings to get our bull and crow count*/
            else
            {
                /*check the strings at their particular index to see if bulls exist
                   if they do we will add them to the list box and label it with the attempt count*/
                bullsListBox.Items.Add("Attemot: " + guessCount.ToString());
                for(int i = 0; i < inputVal.Length; i++)
                {
                    if(inputVal[i] == guessVal[i])
                    {
                        bullsListBox.Items.Add(guessVal[i].ToString());
                        x++;
                    }
                }

                /*compare each string in any order to find if any crows exist
                  if they do we will add them to the list box and label it with the attempt count*/
                //need to add logic to check if its a duplicate to --y and not add it to the listbox.
                crowsListBox.Items.Add("Attempt: " + guessCount.ToString());
                for (int k = 0; k < inputVal.Length; k++)
                {
                    for (int j = 0; j < guessVal.Length; j++)
                    {                        
                        if (inputVal[k].ToString() == guessVal[j].ToString())
                        {                           
                            crowsListBox.Items.Add(guessVal[j].ToString());
                            y++;
                        }
                    }
                }
            }

          /*Check(s) if we need to populate any values in our total Bulls/Crows Boxes*/
            if (x > 0)
            {
                bullsTotalCount.Text = x.ToString();
            }
            else
                bullsTotalCount.Text = "No Bulls Yet.";
            if (y > 0)
            {
                crowsTotalCount.Text = y.ToString();
            }
            else
                crowsTotalCount.Text = "No Crows Yet.";
        }

        /*Method for our win condition can either start over of exit*/
        public void winConditions(bool ismatch)
        {
            //ask for rematch etc, reload form with cleared data etc
            if(ismatch == true)
            {
               
                MessageBox.Show("Winner!");
                DialogResult resultOf = MessageBox.Show("Play Again?", "Exit", MessageBoxButtons.YesNo);
                if (resultOf == DialogResult.Yes)
                {
                    this.Close();
                    th = new Thread(newForms);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();                  
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        /*Method for our lose condition can either start over of exit*/
        public void loseConditions()
        {
            //ask for rematch etc, reload form with cleared data etc
            MessageBox.Show("Loser" + "\n" + "The value was: " + inputBox.Text);
            DialogResult resultOf = MessageBox.Show("Play Again?", "Exit", MessageBoxButtons.YesNo);
            if (resultOf == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(newForms);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                Application.Exit();
            }
        }

        /*added validate method to insure the text inputs are the same length*/
        public bool ValidateBoxes(string input, string output)
        {
            if (output.Length == input.Length)
            {
                return true;
            }
            else
            return false;
        }

        /*send our form object to this method to intialze a new one*/
        private void newForms(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
                     
        
    

                   
        