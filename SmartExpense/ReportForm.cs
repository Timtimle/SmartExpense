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
            string modelFile = "model.json";
            Multiclass_LogicsticRegression mlr = new Multiclass_LogicsticRegression();

            txtTotalExpenses.Text = manager.GetTotal().ToString("N0");

            if (File.Exists(modelFile)) {
                mlr.LoadModel(modelFile);
            } else {
                mlr.LoadTrainingData();
                mlr.Train(mlr.getTrainingData(), 100, true);

                mlr.SaveModel(modelFile);
            }

            string input = "mua bao cao su";
            Vietnamese vietnamese = new Vietnamese();
            string inputNoDiacritics = vietnamese.RemoveDiacritics(input);
            string category = mlr.Classify(inputNoDiacritics);

            string testFile = "test.txt";

            List<ExpenseData> testData = new List<ExpenseData> {
                new ExpenseData("Ăn Uống", vietnamese.RemoveDiacritics("ăn cơm").ToLower()),
                new ExpenseData("Mua Sắm", vietnamese.RemoveDiacritics("con di me may").ToLower()),
                new ExpenseData("Giải Trí", vietnamese.RemoveDiacritics("xem phim").ToLower())
            };

            double accuracy = mlr.EvaluateAccuracy(testData);

            //if (File.Exists(testFile)) {
            //    List<ExpenseData> testData = mlr.LoadFromCsv(testFile).Select(d => new ExpenseData(d.Label, vietnamese.RemoveDiacritics(d.Text))).ToList();
            //    accuracy = mlr.EvaluateAccuracy(testData);
            //    Console.WriteLine($"Model accuracy: {accuracy:P2}");
            //} else {
            //    Console.WriteLine("Test file not found. Skipping evaluation.");
            //}

            MessageBox.Show($"Input: {input}\nPredicted Category: {category}\nAccuracy (test set): {accuracy:P2}","Prediction Result");
        }

        private void ReportForm_Load(object sender, EventArgs e) {
            txtTotalExpenses.BackColor = Color.White;
            txtTotalExpenses.BorderStyle = BorderStyle.FixedSingle;
            txtTotalExpenses.AutoSize = false;
            txtTotalExpenses.TextAlign = ContentAlignment.MiddleLeft;
            txtTotalExpenses.Size = new Size(100, 25);

            UpdateTotal();
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
