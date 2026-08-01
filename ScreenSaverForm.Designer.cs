namespace jsscreenSaver
{
	partial class ScreenSaverForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
//				rssDescriptionView.Dispose();
//				rssItemsView.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblNowTime = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtNewLine = new System.Windows.Forms.TextBox();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowTime
            // 
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblNowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F);
            this.lblNowTime.ForeColor = System.Drawing.Color.Gray;
            this.lblNowTime.Location = new System.Drawing.Point(134, -24);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(679, 149);
            this.lblNowTime.TabIndex = 1;
            this.lblNowTime.Text = "HH:mm:ss";
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.Black;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.CausesValidation = false;
            this.txtText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtText.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtText.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txtText.Location = new System.Drawing.Point(19, 170);
            this.txtText.Margin = new System.Windows.Forms.Padding(2);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ShortcutsEnabled = false;
            this.txtText.Size = new System.Drawing.Size(548, 113);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "fvkxqeweu";
            this.txtText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseUp);
            // 
            // txtNewLine
            // 
            this.txtNewLine.BackColor = System.Drawing.Color.Black;
            this.txtNewLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewLine.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewLine.Location = new System.Drawing.Point(287, 319);
            this.txtNewLine.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewLine.Multiline = true;
            this.txtNewLine.Name = "txtNewLine";
            this.txtNewLine.Size = new System.Drawing.Size(154, 54);
            this.txtNewLine.TabIndex = 4;
            this.txtNewLine.Text = "--------";
            this.txtNewLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNewLine_MouseUp);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPageNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPageNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageNo.Location = new System.Drawing.Point(317, 378);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(69, 21);
            this.lblPageNo.TabIndex = 0;
            this.lblPageNo.Text = "1 / 23   ";
            this.lblPageNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.BackColor = System.Drawing.Color.Transparent;
            this.lblKeys.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.ForeColor = System.Drawing.Color.DimGray;
            this.lblKeys.Location = new System.Drawing.Point(29, 346);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(72, 19);
            this.lblKeys.TabIndex = 5;
            this.lblKeys.Text = "Alt + S";
            this.lblKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.txtNewLine);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblNowTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ScreenSaverForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtNewLine;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Label lblKeys;
    }
}