namespace SmartExpense {
    public partial class ReportForm : Form {
        private ExpenseManager manager = new ExpenseManager();

        public ReportForm() {
            InitializeComponent();
            this.Load += ReportForm_Load;
        }

        public ReportForm(ExpenseManager expense) {
            InitializeComponent();
            this.manager = expense;
            this.Load += ReportForm_Load;
        }

        public void UpdateTotal() {
            txtTotalExpenses.Text = manager.GetTotal().ToString("N0");
        }

        private void ReportForm_Load(object sender, EventArgs e) {
            txtTotalExpenses.BackColor = Color.White;
            txtTotalExpenses.BorderStyle = BorderStyle.FixedSingle;
            txtTotalExpenses.AutoSize = false;
            txtTotalExpenses.TextAlign = ContentAlignment.MiddleLeft;
            txtTotalExpenses.Size = new Size(100, 25);

            UpdateTotal();

            Multiclass_LogicsticRegression lr = new Multiclass_LogicsticRegression();
            lr.LoadTrainingData();
            lr.Train(lr.getTrainingData(), true);
        }

        private void totalExpenses_Click(object sender, EventArgs e) {

        }

        private void foodAndDrink_Click(object sender, EventArgs e) {

        }

        private void entertaiment_Click(object sender, EventArgs e) {

        }

        private void other_Click(object sender, EventArgs e) {

        }

        private void TxtTotalExpenses(object sender, EventArgs e) {

        }

        private void ReportForm_Load_1(object sender, EventArgs e) {

        }
    }
}
