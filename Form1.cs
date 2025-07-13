using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch8._9
{
    public partial class CharToNum : Form
    {
        public CharToNum()
        {
            InitializeComponent();
            string UserGuess = UserInput.Text.Trim();
        }

        //method for ensuring the users input is correct
        private void Validation(string str)
        {
            string UserGuess = UserInput.Text.Trim();
            int StrLength = 14;
            StrLength.ToString();
            //User Guess must match the length of the how the format is showed on the app page
            if (UserGuess.Length > StrLength)
            {
                MessageBox.Show("Your Number is too long enter less charaters");
            }
            bool valid = false;
           
            //if user does not have parenthesis and dashes the user is told it is invalid
                if (UserGuess[0] == '(' && UserGuess[4] == '-' && UserGuess[8] == '-' && UserGuess[13] == ')')
                {
                    valid = true;
                }
                else
                {
                    MessageBox.Show("The number you have entered is invalid look to the format that is asked " +
                        "for.");
                }
            //}
            
        }
        private string Conversion(string str)
        {

            string UserGuess = UserInput.Text.Trim();
            

            int countVar = 0;
            
            //likely a problem with the < or you must enstate the length
            for (countVar = 0; countVar < UserGuess.Length; countVar++)
            {
                //VERY INEFFECIENT APPROACH TALK TO PROFRESSOR ON HOW TO CONDENSE IT
                //checks to see if users input at any point has these 1 letters

                //countVar will represent each letter in user input
                if (UserGuess[countVar] == 'A' || UserGuess[countVar] == 'B' || UserGuess[countVar] == 'C')
                {
                    //if the letters are found they are replaced with 2 
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "2");
                }
                if (UserGuess[countVar] == 'D' || UserGuess[countVar] == 'E' || UserGuess[countVar] == 'F')
                {
                    //if the letters are found they are replaced with 3 
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "3");
                }
                if (UserGuess[countVar] == 'G' || UserGuess[countVar] == 'H' || UserGuess[countVar] == 'I')
                {
                    //if the letters are found they are replaced with 4 
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "4");
                }
                if (UserGuess[countVar] == 'J' || UserGuess[countVar] == 'K' || UserGuess[countVar] == 'L')
                {
                    //if the letters are found they are replaced with 5 
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "5");
                }
                if (char.ToUpper(UserGuess[countVar]) == 'M' || (char.ToUpper(UserGuess[countVar]) == 'N' || char.ToUpper(UserGuess[countVar]) == 'O'))
                {
                    //if the letters are found they are replaced with 6
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "6");
                }
                if (UserGuess[countVar] == 'P' || UserGuess[countVar] == 'Q' || UserGuess[countVar] == 'R' || UserGuess[countVar] == 'S')
                {
                    //if the letters are found they are replaced with 7
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "7");
                }
                if (UserGuess[countVar] == 'T' || UserGuess[countVar] == 'U' || UserGuess[countVar] == 'V')
                {
                    //if the letters are found they are replaced with 8
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "8");
                }
                if (UserGuess[countVar] == 'W' || UserGuess[countVar] == 'X' || UserGuess[countVar] == 'Y' || UserGuess[countVar] == 'Z')
                {
                    //if the letters are found they are replaced with 9
                    UserGuess = UserGuess.Replace(UserGuess[countVar].ToString(), "9");
                }



            }
            return UserGuess;





        }

        //ensure that the user can only enter symbols for parenthesis and dashes as well as letters and numbers
        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)
                && !char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Button runs program and all methods are called to get a final result
        private void RunBtn_Click(object sender, EventArgs e)
        {
            string UserGuess = UserInput.Text.Trim();
            Validation(UserGuess);
            string first = UserGuess;
            ResultLbl.Text = Conversion(first);
            //int StrLength = UserGuess.Length;
           // MessageBox.Show(StrLength.ToString());

            
            


        }
        //Exits the program upon clicking 
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
