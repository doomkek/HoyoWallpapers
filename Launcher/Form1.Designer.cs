namespace Launcher;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btn_Close = new Button();
        pictureBox1 = new PictureBox();
        webServiceWorker = new System.ComponentModel.BackgroundWorker();
        notifyIcon1 = new NotifyIcon(components);
        TrayMenu = new ContextMenuStrip(components);
        Quit = new ToolStripMenuItem();
        btn_SchTask = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        TrayMenu.SuspendLayout();
        SuspendLayout();
        // 
        // btn_Close
        // 
        btn_Close.Location = new Point(156, 249);
        btn_Close.Name = "btn_Close";
        btn_Close.Size = new Size(106, 23);
        btn_Close.TabIndex = 1;
        btn_Close.Text = "Close process";
        btn_Close.UseVisualStyleBackColor = true;
        btn_Close.Click += btn_Close_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.firefox_HmKtP4kxhZ;
        pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(250, 231);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // notifyIcon1
        // 
        notifyIcon1.BalloonTipText = "Lmao even";
        notifyIcon1.BalloonTipTitle = "Lol";
        notifyIcon1.ContextMenuStrip = TrayMenu;
        notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
        notifyIcon1.Text = "Genshin Wallpaper";
        notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
        // 
        // TrayMenu
        // 
        TrayMenu.Items.AddRange(new ToolStripItem[] { Quit });
        TrayMenu.Name = "Quit";
        TrayMenu.Size = new Size(98, 26);
        TrayMenu.ItemClicked += TrayMenu_ItemClicked;
        // 
        // Quit
        // 
        Quit.Name = "Quit";
        Quit.Size = new Size(97, 22);
        Quit.Text = "Quit";
        // 
        // btn_SchTask
        // 
        btn_SchTask.Location = new Point(12, 249);
        btn_SchTask.Name = "btn_SchTask";
        btn_SchTask.Size = new Size(138, 23);
        btn_SchTask.TabIndex = 3;
        btn_SchTask.Text = "Create Schedule Task";
        btn_SchTask.UseVisualStyleBackColor = true;
        btn_SchTask.Click += btn_SchTask_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(274, 284);
        Controls.Add(btn_SchTask);
        Controls.Add(pictureBox1);
        Controls.Add(btn_Close);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Launcher";
        FormClosing += Form1_FormClosing;
        Load += Form1_Load;
        Resize += Form1_Resize;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        TrayMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button btn_Close;
    private PictureBox pictureBox1;
    private System.ComponentModel.BackgroundWorker webServiceWorker;
    private NotifyIcon notifyIcon1;
    private ContextMenuStrip TrayMenu;
    private ToolStripMenuItem Quit;
    private Button btn_SchTask;
}
