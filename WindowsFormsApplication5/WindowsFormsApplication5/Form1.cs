using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string moneyShow;
        double money;

        #region mainButton
        private void button1_Click(object sender, EventArgs e)
        {
            moneyShow = textBox1.Text;
            MessageBox.Show(moneyShow.ToString());
            Double.TryParse(moneyShow, out money);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region addTrillion
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string addT = textBox2.Text;
            double addTrill;
            Double.TryParse(addT, out addTrill);
            // change to a double
            addTrill = addTrill * 0.109;
            //set to trillion
            money = money + addTrill;
            //new money arranged
            MessageBox.Show("Trillion Added, New money is: " + money.ToString());

        }
        #endregion

        #region add Billion
        private void button3_Click(object sender, EventArgs e)
        {
            double addBill;
            string addB = textBox3.Text;
            Double.TryParse(addB, out addBill);
            //changed to double
            addBill= addBill * 1.07;
            //set to billion currency
            money = money + addBill;
            MessageBox.Show("Billion added, New money is : " + money.ToString());
        }
        #endregion

        #region add Nonillion
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double addNonill;
            string addN= textBox4.Text;
            Double.TryParse(addN, out addNonill);
            //changed to double
            addNonill = addNonill * 0.0121;
            //set to nonill currency
            money = money + addNonill;
            MessageBox.Show("Added Nonillion, New money is: " + money);
        }
        #endregion

        #region subtractTrillion
        private void button5_Click(object sender, EventArgs e)
        {
            double subtractTrillion;
            string subtractT = textBox2.Text;
            Double.TryParse(subtractT, out subtractTrillion);
            //changed to double
            subtractTrillion = subtractTrillion * 0.109;
            //changed to trillion currency
            money = money - subtractTrillion;
            if (money < 0) {
                money = money + subtractTrillion;
                MessageBox.Show("Substraction is not made because the value is returned negative");
            } 
            else {
                MessageBox.Show("Subtracted Trillion, New money is: " + money.ToString());
            }

            //
        }
        #endregion

        #region subtractBillion
        private void button6_Click(object sender, EventArgs e)
        {
            double subtractBillion;
            string substractB = textBox3.Text;
            Double.TryParse(substractB, out subtractBillion);
            // cahnged to double
            subtractBillion = subtractBillion * 1.07;
            // changed to billion currency
            money = money - subtractBillion;
            if(money < 0) {
                money = money + subtractBillion;
                MessageBox.Show("The subtraction is not made because the value is returned negative");
            }
            else {
                MessageBox.Show("The billion subtracted,New money is: " + money.ToString());
            }

        }
        #endregion

        #region subtractNonillion
        private void button7_Click(object sender, EventArgs e)
        {
            double subtractNonillion;
            string subtractN = textBox4.Text;
            Double.TryParse(subtractN, out subtractNonillion);
            // changed to double
            subtractNonillion = subtractNonillion * 0.0121;
            //changed to nonillion currency
            money = money - subtractNonillion;
            if (money < 0) {
                money = money + subtractNonillion;
                MessageBox.Show("Subtraction is not made because the value is returned negative");
            }
            else {
                MessageBox.Show("Nonillion is subtracted, New money is: " + money);
            }
        }
        #endregion

    }


}
