using System;
using System.Windows.Forms;

namespace jsscreenSaver
{
    public partial class UserSettingForm : Form
    {
        public UserSettingForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
        }

        string sql;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = @"update user_setting set  
[user_idle_timer] = $user_idle_timer, 
[content_display_timer] = $content_display_timer, 
[content_font_size] = $content_font_size , 
[content_font_familyName] = '$content_font_familyName' ; "
            ;

            sql = sql.Replace("$user_idle_timer", setting.user_idle_timer.ToString());
            sql = sql.Replace("$content_display_timer", setting.content_display_timer.ToString());
            sql = sql.Replace("$content_font_size", setting.content_font_size.ToString());
            sql = sql.Replace("$content_font_familyName", setting.content_font_familyName);
            db.execute_nonquery(sql);
            jss.userSetting = new UserSetting();
            Hide();
        }
        UserSetting setting;
        private void UserSettingForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                setting = new UserSetting();
                propertyGrid1.SelectedObject = setting;
            }
            else
            {
            }
        }
    }
}