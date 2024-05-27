using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Launcher;
public static class WallpaperScheduler
{
    const string TASK_NAME = "GenshinWallpaper";
    static TaskService ts = new TaskService();

    public static void CreateScheduleTask()
    {
        var fn = Path.Combine(AppContext.BaseDirectory, $"{AppDomain.CurrentDomain.FriendlyName}.exe");

        TaskDefinition td = ts.NewTask();
        Trigger trigger = new LogonTrigger(); // need admin rights to use that type of trigger
        td.Triggers.Add(trigger);
        td.Actions.Add(new ExecAction(fn, "no-tray", AppContext.BaseDirectory));
        ts.RootFolder.RegisterTaskDefinition(TASK_NAME, td);
    }

    public static bool IsTaskRegistered() => ts.RootFolder.AllTasks.FirstOrDefault(t => t.Name == TASK_NAME) != null;

    public static void RemoveScheduleTask() => ts.RootFolder.DeleteTask(TASK_NAME, false);
}
