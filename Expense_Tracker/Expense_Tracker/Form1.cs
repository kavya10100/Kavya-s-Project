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
    public partial class Form1 : Form
    {
        // list of Expense
        List<Expense> expenses = new List<Expense>();
        /// <summary>
        /// update expense list
      
        /// </summary>
        void UpdateExpense()

        {
            //remove everything
            ExpenseGrid.Rows.Clear();
            //add everything from the list
            for (int index= 0; index < expenses.Count; index++)
            {
                ExpenseGrid.Rows.Add(
                    expenses[index].GetDate().ToString("yyyy-MM-dd"),
                    expenses[index].GetDedcription(),
                    expenses[index].GetAmount().ToString("F2")
                  );
            }
        }

        public Form1()
        {
            InitializeComponent();
            expenses.Add(new Expense(new DateTime(2024,2,3), "Grocery Shopping", 150));
            expenses.Add(new Expense(new DateTime(2024, 3, 13), "Gas Bill", 75));
            expenses.Add(new Expense(new DateTime(2024, 2, 3), "Phone Bill", 96));
            expenses.Add(new Expense(new DateTime(2024, 2, 3), "Dinner at a restruant", 70));
            expenses.Add(new Expense(new DateTime(2024, 2, 3), "Pesonal shopping", 100));


            UpdateExpense();
            

        }


        // Method to calculate and display total expenses and remaining budget
        private void UpdateBudget()
        {
            // Calculate total expenses
            double totalExpenses = expenses.Sum(expense => expense.GetAmount());
            //get the budget
            double budget = (double)numericUpDown1.Value;  // Use numericUpDown1 to get the budget

            // Update total expenses in ExpensesTextBox
            ExpensesTextBox.Text = totalExpenses.ToString("F2");

            // Calculate and display remaining balance in BalanceTextBox
            double remainingBalance = budget - totalExpenses;
            BalanceTextBox.Text = remainingBalance.ToString("F2");

           
        }

        
        /// <summary>
        /// shows new add expense model window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            //add a new expense
            Add_New_Expenses add_New_Expenses = new Add_New_Expenses(expenses);

            //show the form
            add_New_Expenses.ShowDialog();

            //update list GUI
            UpdateExpense();
            UpdateBudget();

        }
        /// <summary>
        /// Remve selcted ecpense from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Removebutton_Click(object sender, EventArgs e)
        {
            //nothing to remove
            if(expenses.Count == 0)
            {
                MessageBox.Show("List is alredy empty!");
                return;
            }

            //get the index of selected row
            int expenseIndex = ExpenseGrid.CurrentRow.Index;
            //remove from list
            expenses.RemoveAt(expenseIndex);
            //update GUI
            UpdateExpense();
            UpdateBudget();

        }
        /// <summary>
        /// update the blance when budget the changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged_2(object sender, EventArgs e)
        {
            UpdateBudget();
        }
    }
}
