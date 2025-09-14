using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartExpense {
    public partial class AddExpenseForm : Form {
        ExpenseManager manager = new ExpenseManager();

        public AddExpenseForm() {
            InitializeComponent();
        }

        private void AmountLb(object sender, EventArgs e) {
            try {
                decimal amount = decimal.Parse(txtAmount.Text);
                MessageBox.Show("Valid amount: " + amount);
            }
            catch (FormatException) {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
            }
        }

        private void DateLb(object sender, EventArgs e) {
            DateTime date = dateTimePicker1.Value;
        }

        private void DescriptionLb(object sender, EventArgs e) {
            string description = txtDescription.Text;

            if (!string.IsNullOrWhiteSpace(description)) {
                MessageBox.Show("Valid description: " + description);
            }
            else {
                MessageBox.Show("Descripton cannot be empty");
            }
        }

        private void SaveLb(object sender, EventArgs e) {
            decimal amount = decimal.Parse(txtAmount.Text);
            string description = txtDescription.Text;
            DateTime date = dateTimePicker1.Value;
            string category = "unknown";

            if (string.IsNullOrWhiteSpace(txtAmount.Text)) {
                MessageBox.Show("Amount cannot be empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(description)) {
                MessageBox.Show("Description cannot be empty");
                return;
            }

            Expense newExpense = new Expense(amount, description, date, category);

            manager.AddExpense(newExpense);

            dataGridViewExpenses.DataSource = null;
            dataGridViewExpenses.DataSource = manager.Expenses;

            MessageBox.Show("Save OK");
        }

        private void AddExpenseForm_Load(object sender, EventArgs e) {
            manager.LoadExpensesFromFile();

            dataGridViewExpenses.DataSource = null;
            dataGridViewExpenses.DataSource = manager.Expenses;
        }

        private void DoneLabel_Click(object sender, EventArgs e) {
            ReportForm form1 = new ReportForm(manager); // pass manager to ReportForm
            form1.Show();
            this.Hide();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e) {

        }
    }
}
