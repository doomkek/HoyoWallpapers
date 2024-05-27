namespace Launcher;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(params string[] args)
    {
        if (!Directory.Exists("wallpapers"))
            Directory.CreateDirectory("wallpapers");

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(args));
    }
}