using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExpense
{
    internal class Expense
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Catergory { get; set; }
        public DateTime Date { get; set; }

        public Expense(decimal amount, string description, string category, DateTime date)
        {
            this.Amount = amount;
            this.Description = description;
            this.Category = category;
            this.Date = date;
        }
    }

    internal class ExpenseList
    {
        List<Expense> Data = new List<Expense>();

        public void AddExpense(Expense x) => Data.Add(x);
    }

    internal class KMeans
    {
        private string category = "";
        
        public string Predict(string x)
        {
            if (x..Contains == 'an') => category = "Food";
            else if (x.Contains == 'choi') => category = "Entertaiment";
            else category = "Other";
        }
    }
}
