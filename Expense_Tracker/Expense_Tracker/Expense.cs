using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class Expense
    {
        //only this class can use these
        private DateTime Date;
        private string Description;
        private double Amount;
        /// <summary>
        /// constructor- add new expense 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        public Expense(DateTime date, string description, double amount)
        {
            this.Date = date;
            this.Description = description;
            this.Amount = amount;
        }
        //Get the date of new expense added
        public DateTime GetDate()
        {
            return Date.Date;
        }

        //Get the description of new expense added
        public string GetDedcription()
        {
            return Description;
        }

        //Get the Amount of new expense added
        public double GetAmount()
        {
            return Amount;
        }
    }
}
