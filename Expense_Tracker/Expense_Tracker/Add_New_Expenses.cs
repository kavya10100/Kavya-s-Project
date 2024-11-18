using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class Add_New_Expenses : Form
    {
        //Accessible in the whole class
        List<Expense> expenseList;
        public Add_New_Expenses(List<Expense> expenseList)
        {
            InitializeComponent();
            this.expenseList = expenseList;
        }
        /// <summary>
        /// close the model window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();

        }
        /// <summary>
        /// add new expense to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExpensebutton_Click(object sender, EventArgs e)
        {
            //GET the date, description, and amount in GUI
            DateTime date = dateTimePicker1.Value;
            string Description = DescriptiontextBox.Text;
            double Amount = (double) AmountUpDown.Value;

            //make sure we have a name
            if(DescriptiontextBox.Text == "")
            {
                MessageBox.Show("You must have description for your expense");
                return;
            }

            //create a new Expense object
            Expense newExpense = new Expense(date,Description,Amount);

            //add the expense to list
            expenseList.Add(newExpense);

            // Calculate the total expense
            double totalExpense = expenseList.Sum(exp => exp.GetAmount());

            


            //close the model window
            Close();
        }
    }
}
