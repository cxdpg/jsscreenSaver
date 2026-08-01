jsScreenSaver — A screen reminder utility.

This software acts like a screensaver that activates after a period of user inactivity (15 minutes by default). Once triggered, it displays the current time along with customizable text messages, such as to-do lists, motivational quotes, reminders, or other short notes (by default, the text switches to the next entry every 45 minutes). It turns your computer into a clock while also helping you keep track of important reminders.

Text entries are fully user-editable:

Add: Press the Tab key to move focus to the text input area, type your message, and press Ctrl + S to save.

Edit: Modify the text directly, then press Ctrl + S to save.

Delete: Clear the content, then press Ctrl + S to save.

After installation, a persistent purple icon will appear in the system tray (bottom-right corner of the screen). Right-click this icon to access settings, where you can configure the inactivity timeout period, the display duration for each text entry, and other options.

Keyboard shortcuts:

ESC or right-click — Exit the screensaver

Tab — Switch focus between text boxes

Ctrl + S — Save and view the next entry

Alt + S — Save and view the previous entry

Ctrl + R — Save and view a random entry

Alt + 1 — Save and view the last entry

Tech stack:

Written in C# targeting .NET Framework 4.7.2

IDE: Visual Studio 2019
Database:Sqlite


屏幕提醒程序jsScreenSaver，

作用是在用户长时间未有动作时（默认是15分钟），像屏幕保护程序一样启动，显示时间，显示待办事项、小警句、小提醒等文字（默认每45分钟换下一条文字）。它把电脑用作一个时钟，也可以提醒一些事情。

文字内容由用户输入，可以新增、修改、删除 
新增：按Tab键将键盘输入焦点切换到--------------------位置，随便写点文字，按Ctrl + S 保存
修改：直接修改，按Ctrl + S 保存
删除：将内容清空，按Ctrl + S 保存
 
安装后，在屏幕右下角的系统托盘里，会有一个常驻的紫色小图标，鼠标右击这个小图标，可以做一些设置，如用户多长时间未动作就启动屏幕提醒程序，每条文字的显示时间等。 

ESC 或 鼠标右键 退出  
TAB 切换选中的文本框 
Ctrl + S 保存，查看下一条
Alt  + S 保存，查看上一条 
Ctrl + R 保存，查看随机的一条 
Alt  + 1 保存，查看最后一条


written in C# against the .NET Framework 4.7.2
IDE:Visual studio 2019
Database:Sqlite
