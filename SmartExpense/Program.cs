namespace SmartExpense {
    internal static class Program {
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Application.Run(new AddExpenseForm());
        }
    }
}