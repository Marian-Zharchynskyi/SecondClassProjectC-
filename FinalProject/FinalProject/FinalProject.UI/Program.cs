using FinalProject.UI;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        /*LoginForm loginForm = new LoginForm();*/
        LoginForm loginForm = new LoginForm();

        // ³���������� ����� �����
        Application.Run(loginForm);

        // ��������, �� ���� �� ������ � ��������
        if (PersonalData.Login != null && PersonalData.Password != null)
        {
            // ³���������� ������� ����� ��� ������� �����
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
