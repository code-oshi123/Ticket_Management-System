namespace Dbex
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

            //Application.Run(new Organizer());
            //Application.Run(new Admin_Login());
            //Application.Run(new User());
            //Application.Run(new Roleselection());


            Application.Run(new splash());
            //Application.Run(new UserEventHomeForm3());
            //Application.Run(new AdminDashboardForm());
            //Application.Run(new UserEventHomeForm3());

            //Application.Run(new OrganizerMenuEventForm());
            //Application.Run(new DeleteEventForm());







            //Application.Run(new Payment_Organizer());
            //Application.Run(new Payment_Admin());
            //Application.Run(new Payment_User());




        }
    }
}