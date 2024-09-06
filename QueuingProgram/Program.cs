namespace QueuingProgram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QueuingForm queuingForm = new QueuingForm();
            CashierWindowQueue cashierWindowQueue = new CashierWindowQueue();
            

            cashierWindowQueue.Show();
            

            Application.Run(queuingForm);
        }
    }
}