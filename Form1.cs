using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drink1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        public bool checkprice(int price) {
           bool morethan = true ;
            int Comparable = 1;
            if (price == Comparable)
            {
                morethan = true;

            }
            else {
                return morethan = false;
            }
        

            return morethan; 
        }
        /*public decimal Amountclick(int amount) {
            decimal amounts=1;
            if (checkprice(amount)) {

                return amounts =1;

            }
            else {


                return amounts = 1.50m;



            }


            return amounts;

        }*/
       
        private void Button2_Click(object sender, EventArgs e)
        {
            int total;  
            int.TryParse(cotext.Text,out total);
           
            total = total-1; 

            cotext.Text = total.ToString();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
