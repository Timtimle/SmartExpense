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
        }

        public void UpdateTotal() {
            txtTotalExpenses.Text = manager.GetTotal().ToString("NO");
        }

        private void ReportForm_Load(object sender, EventArgs e) {
            txtTotalExpenses.BackColor = Color.White;
            txtTotalExpenses.BorderStyle = BorderStyle.FixedSingle;
            txtTotalExpenses.AutoSize = false;
            txtTotalExpenses.TextAlign = ContentAlignment.MiddleLeft;

            
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
    }
}
