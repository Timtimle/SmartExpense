namespace SmartExpense
{
    partial class AddExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new Label();
            txtDescription = new Label();
            dateLabel = new Label();
            saveLabel = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.AutoSize = true;
            txtAmount.Location = new Point(12, 94);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(51, 15);
            txtAmount.TabIndex = 0;
            txtAmount.Text = "Amount";
            txtAmount.Click += amountLabel_Click;
            // 
            // txtDescription
            // 
            txtDescription.AutoSize = true;
            txtDescription.Location = new Point(12, 126);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(67, 15);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "Description";
            txtDescription.Click += descriptionLabel_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(12, 159);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 15);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            dateLabel.Click += dateLabel_Click;
            // 
            // saveLabel
            // 
            saveLabel.AutoSize = true;
            saveLabel.Location = new Point(12, 194);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(31, 15);
            saveLabel.TabIndex = 3;
            saveLabel.Text = "Save";
            saveLabel.Click += saveLabel_Click;
            // 
            // AddExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveLabel);
            Controls.Add(dateLabel);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Name = "AddExpenseForm";
            Text = "AddExpenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAmount;
        private Label txtDescription;
        private Label dateLabel;
        private Label saveLabel;
    }
}