namespace peeshop
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            if (AppData.isLogin)
            {

                if (AppData.role == AppData.ROLE_USER)
                {
                    Application.Run(new OrderMaker());
                }else
                {
                    Application.Run(new OrderManagement());
                }
            }
        }
    }
}