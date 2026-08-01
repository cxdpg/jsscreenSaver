using System.ComponentModel;


[DefaultPropertyAttribute("UserSetting")]
public class UserSetting
{
    [CategoryAttribute("screenSaver"), DescriptionAttribute("user idle timer from screenSaver showup ")]
    public int user_idle_timer { get; set; }

    [CategoryAttribute("screenSaver"), DescriptionAttribute("refresh timer interval ")]
    public int content_display_timer { get; set; }
    [CategoryAttribute("screenSaver"), DescriptionAttribute("content font size ")]
    public int content_font_size { get; set; }

    [CategoryAttribute("screenSaver"), DescriptionAttribute("content font familyName ")]
    public string content_font_familyName { get; set; }
    [CategoryAttribute("application"), DescriptionAttribute("enabled ")]
    public bool is_enabled { get; set; } = true;

    public UserSetting()
    {
        var sql = " select * from user_setting ; ";
        var dr = db.get_datarow(sql);
        content_display_timer = int.Parse(dr["content_display_timer"].ToString());
        content_font_size = int.Parse(dr["content_font_size"].ToString());
        content_font_familyName = dr["content_font_familyName"].ToString();
        user_idle_timer = int.Parse(dr["user_idle_timer"].ToString());
    }
}