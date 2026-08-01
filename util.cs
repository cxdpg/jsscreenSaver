using System;
using System.Configuration;
using System.IO;

public static class Util
{
    private static readonly object dummy = new object();
    public static void write_to_log(string s)
    {
        var path = AppDomain.CurrentDomain.BaseDirectory + "abbbbbbbbbbbbbbbbb_" + DateTime.Now.ToString("yyyy_MM_dd") +
                   ".txt";

        lock (dummy)
        {
            var w = File.AppendText(path);
            w.Write(DateTime.Now.ToString("HH:mm:ss :  \n"));
            w.WriteLine(s);
            w.Close();
        }
    }

    public static string get_setting(string key)
    {
        return ConfigurationManager.AppSettings.Get(key);
    }

    public static string ToDateString(this DateTime dt)
    {
        return dt.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public static void WriteLine(this System.Windows.Forms.TextBox text, string str)
    {
        text.Text += str + "\r\n";
        text.SelectionStart = text.Text.Length;
        text.ScrollToCaret();
    }

}