using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SmartExpense {
    public class Expense {
        public decimal amount { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public string category { get; set; }

        public Expense(decimal amount, string description, DateTime date, string category) {
            this.amount = amount;
            this.description = description;
            this.date = date;
            this.category = category;
        }

        public Expense() { }
    }

    public class ExpenseManager {
        private List<Expense> expenses = new List<Expense>();
        private string filePath = "expenses.json";

        public List<Expense> Expenses => expenses;
        public void AddExpense(Expense expense) {
            expenses.Add(expense);
            SaveExpensesToFile();
        }

        public void SaveExpensesToFile() {
            string json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void LoadExpensesFromFile() {
            if (File.Exists(filePath)) {
                string json = File.ReadAllText(filePath);
                expenses = JsonSerializer.Deserialize<List<Expense>>(json);
            }
        }


    }
    internal class KMeans {
        private string category = "";
        
        public string Predict(string x) {
            if (x.Contains("an")) category = "Food";
            else if (x.Contains("choi")) category = "Entertaiment";
            else category = "Other";
            return category; 
        }
    }
}
