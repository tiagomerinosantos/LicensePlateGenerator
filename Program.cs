namespace LicensePlateGenerator
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
            try 
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Existiu um erro ao iniciar a aplicação. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}