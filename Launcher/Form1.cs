using System.Windows.Forms;

namespace Launcher;

public partial class Form1 : Form
{
    string[] args;
    public Form1(string[] args)
    {
        this.args = args;
        InitializeComponent();        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!Directory.Exists("wallpapers"))
            Directory.CreateDirectory("wallpapers");

        if (args.Length > 0 && args[0] == "no-tray")
        {
            notifyIcon1.Visible = false;
            Hide();
            ShowInTaskbar = false;
            Visible = false;
        }

        btn_SchTask.Text = $"{(WallpaperScheduler.IsTaskRegistered() ? "Remove" : "Create")} Schedule Task";
        webServiceWorker.DoWork += (e, a) => WebServer.CreateWebServer();
        webServiceWorker.RunWorkerAsync();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        if (FormWindowState.Minimized == this.WindowState)
        {
            notifyIcon1.Visible = true;
            Hide();
        }
        else if (FormWindowState.Normal == this.WindowState)
        {
            notifyIcon1.Visible = false;
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            notifyIcon1.Visible = true;
            this.Hide();
            e.Cancel = true;
        }
    }

    private void notifyIcon1_DoubleClick(object sender, EventArgs e)
    {
        this.Show();
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void TrayMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem.Text == "Quit")
            Application.Exit();
    }

    private void btn_SchTask_Click(object sender, EventArgs e)
    {
        if (WallpaperScheduler.IsTaskRegistered())
            WallpaperScheduler.RemoveScheduleTask();
        else
            WallpaperScheduler.CreateScheduleTask();

        btn_SchTask.Text = $"{(WallpaperScheduler.IsTaskRegistered() ? "Remove" : "Create")} Schedule Task";
    }
}
