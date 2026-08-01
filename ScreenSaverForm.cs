using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace jsscreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        static Timer timerNowTime = new Timer();
        static Timer timerNextNote = new Timer();
        Random r;
        int note_index;

        string seperate_symbol = "-----------------------";

        public ScreenSaverForm()
        {
            InitializeComponent();

            // Capture the mouse
            //this.Capture = true;
            this.KeyPreview = true;

            Bounds = Screen.PrimaryScreen.Bounds;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            ShowInTaskbar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            int pad = 5;
            lblNowTime.Location = new Point(Size.Width / 2 - lblNowTime.Width / 2, pad * 2);
            //lblNowTime.Font = new Font("Font.", 88);
            lblNowTime.AutoSize = true;
            lblNowTime.Focus();

            lblKeys.Text = "\r\n\r\nCtrl + S  Alt + S\r\nCtrl + R  Alt + 1";
            lblKeys.Text += "\r\n(right click || ESC) to quit()";
            lblKeys.Location = new Point(pad * 6, Size.Height - 120);

            lblPageNo.Location = new Point(Size.Width / 2 - lblPageNo.Width / 2, Size.Height - lblPageNo.Height - pad * 2);

            txtText.Location = new Point(pad, lblNowTime.Height + 1);
            txtText.Width = Size.Width - pad * 2;
            txtText.Height = Size.Height - txtText.Location.Y - (Size.Height - lblKeys.Location.Y);

            int temp_Y = lblPageNo.Location.Y - lblPageNo.Height - pad;

            txtNewLine.Text = seperate_symbol;
            txtNewLine.Width = Size.Width - 800;
            txtNewLine.Height = 60;
            txtNewLine.Location = new Point(Size.Width / 2 - txtNewLine.Width / 2, temp_Y);


            refresh_notes_data();
            r = new Random(DateTime.Now.Millisecond);
            note_index = r.Next(1, notes.Count);

            timerNowTime.Enabled = true;
            timerNowTime.Interval = 1000;
            timerNowTime.Tick += new System.EventHandler(this.timer1_Tick);
            timerNowTime.Start();
            timerNextNote.Enabled = true;
            timerNextNote.Interval = jss.userSetting.content_display_timer * 1000;
            timerNextNote.Tick += new System.EventHandler(this.timer2_Tick);
            timerNextNote.Start();

            txtText.Font = new Font(jss.userSetting.content_font_familyName, jss.userSetting.content_font_size);

            update();
        }

        private void TxtText_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        DataRowCollection notes;
        void refresh_notes_data()
        {
            sql = " select count(*) from notes; ";
            if (db.execute_scalar(sql) == "0")
            {
                return;
            }
            sql = " select * from notes ; ";
            notes = db.get_table(sql).Rows;

        }
        void update_notes_data()
        {
            if (note_id == string.Empty)
            {
                return;
            }
            if (original_text == txtText.Text && txtNewLine.Text == seperate_symbol)
            {
                return;
            }
            if (txtText.Text.Trim() == "")
            {
                sql = " delete from notes where id = $id ; ";
            }
            else
            {
                sql = " update notes set text = '$text',update_date = date('now') where id = $id ; ";
            }
            sql = sql.Replace("$text", txtText.Text.Replace("'", "_").Trim());
            sql = sql.Replace("$id", note_id);
            db.execute_nonquery(sql);

            if (txtNewLine.Text != seperate_symbol)
            {
                sql = " insert into notes (text) values('$text') ; ";
            }
            sql = sql.Replace("$text", txtNewLine.Text.Replace("'", "_").Trim());
            db.execute_nonquery(sql);

            refresh_notes_data();
        }
        string note_id = string.Empty;
        string sql;
        string original_text;
        int this_index;
        private void timer2_Tick(object sender, EventArgs e)
        {
            update();
        }
        void update(bool forward = true)
        {
            update_notes_data();
            if (forward)
            {
                note_index++;
            }
            else
            {
                note_index--;
            }
            this_index = (note_index + notes.Count) % notes.Count;
            var n = notes[this_index];
            txtText.Text = n["text"].ToString();
            txtNewLine.Text = seperate_symbol;
            note_id = n["id"].ToString();
            note_index = this_index;
            original_text = n["text"].ToString();
            lblPageNo.Text = (this_index + 1) + " / " + notes.Count;

            timerNextNote.Stop();
            timerNextNote.Start();

            this.lblNowTime.Focus();
        }

        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                scr_hide();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                update();
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.S)
            {
                update(false);
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                note_index = r.Next(1, notes.Count);
                update();
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.D1)
            {
                note_index = -2;
                update();
            }
        }


        private void ScreenSaverForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                scr_hide();
            }
        }


        private void txtText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                scr_hide();
            }
        }

        private void txtNewLine_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                scr_hide();
            }
        }
        void scr_hide()
        {
            this.Hide();
        }


        private void ScreenSaverForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Cursor.Hide();
                timerNextNote.Enabled = true;
                timerNowTime.Enabled = true;
                timerNextNote.Interval = jss.userSetting.content_display_timer * 1000;
                txtText.Font = new Font(jss.userSetting.content_font_familyName, jss.userSetting.content_font_size);
            }
            else
            {
                timerNextNote.Enabled = false;
                timerNowTime.Enabled = false;
                Cursor.Show();
            }
        }
    }
}
