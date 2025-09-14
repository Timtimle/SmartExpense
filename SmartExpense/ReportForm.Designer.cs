namespace SmartExpense
{
    partial class ReportForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            totalExpensesLabel = new Label();
            foodAnDrinkLabel = new Label();
            entertaimentLabel = new Label();
            other = new Label();
            label1 = new Label();
            txtTotalExpenses = new Label();
            SuspendLayout();
            // 
            // totalExpensesLabel
            // 
            totalExpensesLabel.AutoSize = true;
            totalExpensesLabel.Location = new Point(12, 29);
            totalExpensesLabel.Name = "totalExpensesLabel";
            totalExpensesLabel.Size = new Size(83, 15);
            totalExpensesLabel.TabIndex = 0;
            totalExpensesLabel.Text = "Total Expenses";
            totalExpensesLabel.Click += totalExpenses_Click;
            // 
            // foodAnDrinkLabel
            // 
            foodAnDrinkLabel.AutoSize = true;
            foodAnDrinkLabel.Location = new Point(12, 66);
            foodAnDrinkLabel.Name = "foodAnDrinkLabel";
            foodAnDrinkLabel.Size = new Size(88, 15);
            foodAnDrinkLabel.TabIndex = 1;
            foodAnDrinkLabel.Text = "Food and Drink";
            foodAnDrinkLabel.Click += foodAndDrink_Click;
            // 
            // entertaimentLabel
            // 
            entertaimentLabel.AutoSize = true;
            entertaimentLabel.Location = new Point(12, 106);
            entertaimentLabel.Name = "entertaimentLabel";
            entertaimentLabel.Size = new Size(75, 15);
            entertaimentLabel.TabIndex = 2;
            entertaimentLabel.Text = "Entertaiment";
            entertaimentLabel.Click += entertaiment_Click;
            // 
            // other
            // 
            other.AutoSize = true;
            other.Location = new Point(12, 140);
            other.Name = "other";
            other.Size = new Size(58, 15);
            other.TabIndex = 3;
            other.Text = "Shopping";
            other.Click += other_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 177);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Other";
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.AutoSize = true;
            txtTotalExpenses.Location = new Point(122, 29);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.Size = new Size(0, 15);
            txtTotalExpenses.TabIndex = 6;
            txtTotalExpenses.Click += TxtTotalExpenses;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 450);
            Controls.Add(txtTotalExpenses);
            Controls.Add(label1);
            Controls.Add(other);
            Controls.Add(entertaimentLabel);
            Controls.Add(foodAnDrinkLabel);
            Controls.Add(totalExpensesLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalExpensesLabel;
        private Label foodAnDrinkLabel;
        private Label entertaimentLabel;
        private Label other;
        private Label label1;
        private Label txtTotalExpenses;
    }
}
