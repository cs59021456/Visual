using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkNum
{
    public partial class Form1 : Form
    {
        private string input;

        public Form1()
        {
            InitializeComponent();
        }
        private readonly Dictionary<int, char[]> keys =
            new Dictionary<int, char[]>() {
                {1, new char[] {}},
                {2, new[] {'a', 'b', 'c', 'A', 'B', 'C'}},
                {3, new[] {'d', 'D', 'E', 'e', 'f', 'F'}},
                {4, new[] {'g', 'G', 'H', 'h', 'I', 'i'}},
                {5, new[] {'j', 'J', 'K', 'k', 'L','l'}},
                {6, new[] {'m', 'M', 'N', 'n', 'O','o'}},
                {7, new[] {'p', 'P', 'Q', 'q', 'R', 'r', 'S','s'}},
                {8, new[] {'t', 'T', 'U', 'u', 'V','v'}},
                {9, new[] {'w', 'W', 'X', 'x', 'Y', 'y', 'Z', 'z'}},
                //{0, new[] {' '}},
};
        public int[] translate(string text) {
            return text.Select(c=>
                keys.FirstOrDefault(k => k.Value.Contains(c)).Key).ToArray();
  


        }

        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 12; // Length of a valid string
            bool valid = true ; // Flag to indicate validity

            // Determine whether str is properly formatted.
            if (str.Length == VALID_LENGTH && str[3] == '-' &&
            str[7] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            // Return the value of valid.
            return valid;

        }

     




        
        private void Unformat(ref string str)
        {
            // First, delete the left paren at position 0.
            str = str.Remove(3, 1);

            // Next, delete the right paren. Because of the
            // previous deletion it is now located at
            // position 3.
            str = str.Remove(6, 1);

            // Next, delete the hyphen. Because of the
            // previous deletions it is now located at
            // position 6.
            
        }


        private void button1_Click
(object sender, EventArgs e)
        {  
                // Get a trimmed copy of the user's input.
            string input = enternum.Text.Trim();
            
         
            // If the input is properly formatted, unformat it
            // and display it.
            if (IsValidFormat(input))
            {
                Unformat(ref input);


                MessageBox.Show("" + string.Join("", translate(input))) ;
                
            
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid input");
            }
        }

        private void enternum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
