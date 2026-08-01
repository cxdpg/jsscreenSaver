using jscreenSaver;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace jsscreenSaver
{
    public static class jss
    {
        public static NotifyIcon icon;
        public static InfomationForm info;
        public static NotesForm notes;
        public static ScreenSaverForm scr;
        public static UserSettingForm setting;

        public static UserSetting userSetting;

        public static string AppOnlineTime;
        public static string AssemblyLastWriteTime;


        public static void screenSaver(object sender, EventArgs e)
        {
            scr.Show();
            scr.Activate();
        }

        public static void infomation(object sender, EventArgs e)
        {
            info.Show();
            info.Activate();
        }
        public static void notes1(object sender, EventArgs e)
        {
            notes.Show();
            notes.Activate();
        }
        public static void options(object sender, EventArgs e)
        {
            setting.Show();
            setting.Activate();
        }
        public static void exit(object sender, EventArgs e)
        {
            icon.Dispose();
            Application.Exit();
        }
        static string sql;

        static void initialize()
        {
            AppOnlineTime = DateTime.Now.ToDateString();
            AssemblyLastWriteTime = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToDateString();

            userSetting = new UserSetting();

            sql = " insert into sys_startups (version) values ('$vr') ; ";
            sql = sql.Replace("$vr", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            db.execute_nonquery(sql);


            icon = new NotifyIcon();
            icon.Icon = new Icon("emacs.ico");
            icon.ContextMenu = new ContextMenu();
            icon.ContextMenu.MenuItems.Add(" ScreenSaver", screenSaver);
            icon.ContextMenu.MenuItems.Add(" Infomation", infomation);
            icon.ContextMenu.MenuItems.Add(" Notes", notes1);
            icon.ContextMenu.MenuItems.Add(" Options", options);
            icon.ContextMenu.MenuItems.Add(" Exit", exit);
            icon.DoubleClick += infomation;
            icon.Visible = true;

            notes = new NotesForm();
            notes.Visible = false;
            info = new InfomationForm();
            info.Visible = false;
            scr = new ScreenSaverForm();
            scr.Visible = false;
            setting = new UserSettingForm();
            setting.Visible = false;

        }
        [STAThread]
        static void Main()
        {
            bool isFirstInstance;
            using (var mtx = new Mutex(true, "jsscreenSaver.2023.3.8", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    initialize();
                    Application.Run();
                }
                else
                {
                    MessageBox.Show("jsscreenSaver already running . ");
                }
            }
        }
    }
}