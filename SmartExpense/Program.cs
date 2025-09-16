namespace SmartExpense {
    internal static class Program {
        static void Main() {
            ApplicationConfiguration.Initialize();
            //Application.Run(new ReportForm());

            Application.Run(new AddExpenseForm());
        }
    }
}

// Hybrid Rule-based
// ML (Logistic Regression)



