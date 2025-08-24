using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartExpense
{
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveLabel_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(txtDescription.Text);
            string description = txtAmount.Text;
            string category = KMeans(description);
            DateTime date = dateLabel.Text;

            Expense newExpenese = new Expense(amount, description, category, date);

        }

    }
}
