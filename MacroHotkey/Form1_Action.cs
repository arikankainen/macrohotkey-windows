using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        private const int DELAY_ON_START = 500;

        private async Task WaitMillisecondsAsync(int ms)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(ms);
            });
        }

        private int CalculateActionTotalTime(List<string> rows)
        {
            int totalTime = DELAY_ON_START;

            foreach (string row in rows)
            {
                if (row.Length > 0 && !row.StartsWith("#"))
                {
                    Regex regex = new Regex(@"(^.*?)\((.*)\)");
                    Match match = regex.Match(row.ToLower());

                    string command = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    if (command == "delay")
                    {
                        int.TryParse(value, out int delay);
                        if (delay > 0 && delay < 10000) totalTime += delay;
                    }

                }
            }
            
            return totalTime;
        }

        private async Task RunActionAsync(string action)
        {
            if (action != null)
            {
                List<string> rows = action.Split(';').ToList<string>();
                
                notification.TotalTime = CalculateActionTotalTime(rows);
                notification.ShowNotification();
                timerIcon.Start();

                cancel = false;

                await WaitMillisecondsAsync(DELAY_ON_START);

                foreach (string row in rows)
                {
                    if (row.Length > 0)
                    {
                        if (cancel) break;
                        await RunRowAsync(row);
                    }
                }
            }

            notification.HideNotification();
            timerIcon.Stop();
            running = false;
            NotifyIcon1.Icon = this.Icon = Properties.Resources.mh;
        }

        private async Task RunRowAsync(string row)
        {
            try
            {
                if (row.StartsWith("#")) return;

                Regex regex = new Regex(@"(^.*?)\((.*)\)");
                Match match = regex.Match(row.ToLower());

                string command = match.Groups[1].Value;
                string value = match.Groups[2].Value;

                if (command == "key")
                {
                    try
                    {
                        SendKeys.SendWait(value);
                    }
                    catch { }
                }

                else if (command == "delay")
                {
                    try
                    {
                        int.TryParse(value, out int delay);

                        if (delay > 0 && delay < 10000)
                        {
                            await WaitMillisecondsAsync(delay);
                        }
                    }
                    catch { }
                }

                else if (command == "mouseclick")
                {
                    try
                    {
                        if (value == "left") DoMouseClick(MouseButtons.Left);
                        else if (value == "right") DoMouseClick(MouseButtons.Right);
                        else if (value == "middle") DoMouseClick(MouseButtons.Middle);
                    }
                    catch { }
                }

                else if (command == "mousemove")
                {
                    try
                    {
                        List<string> position = value.Split(',').ToList<string>();
                        int x = 0, y = 0;
                        int.TryParse(position[0], out x);
                        int.TryParse(position[1], out y);
                        Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y);
                    }
                    catch { }
                }

                else if (command == "mouseposition")
                {
                    try
                    {
                        List<string> position = value.Split(',').ToList<string>();
                        int x = 0, y = 0;
                        int.TryParse(position[0], out x);
                        int.TryParse(position[1], out y);
                        Cursor.Position = new Point(x, y);
                    }
                    catch { }
                }

                else if (command == "mousemovemonitor")
                {
                    try
                    {
                        bool primary = false;
                        int screenNumber = 1;

                        if (value == "primary") primary = true;
                        else int.TryParse(value, out screenNumber);

                        Screen screen;
                        if (primary) screen = Screen.PrimaryScreen;
                        else screen = Screen.AllScreens[screenNumber - 1];

                        Cursor.Position = screen.Bounds.Location;
                    }
                    catch { }
                }
            }

            catch { }
        }
    }
}
