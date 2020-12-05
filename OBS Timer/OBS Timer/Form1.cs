using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Timer
{
    public partial class Timer_Form : Form
    {
        private DateTime _currentTime;
        private DateTime? _endTime;
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\obs_timer_out.txt";

        public Timer_Form()
        {
            InitializeComponent();
            
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            UpdateCurrentTime();
            endTimePicker.Value = _currentTime;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }


        private void UpdateCurrentTime()
        {
            _currentTime = GetTruncatedTime(DateTime.Now, TimeSpan.FromSeconds(1));
            UpdateClock();
            UpdateTimer();
        }

        private DateTime GetTruncatedTime(DateTime dateTime, TimeSpan timeSpan)
        {
            return dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));
        }

        private void UpdateClock()
        {
            clockLabel.Text = _currentTime.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void UpdateTimer()
        {
            if (_endTime is null)
            {
                timerLabel.Text = "00:00:00:00";
                return;
            }

            TimeSpan timeLeft = (TimeSpan)(_endTime - _currentTime);

            if (timeLeft > TimeSpan.Zero)
            {
                string timerText = timeLeft.ToString(@"dd\:hh\:mm\:ss");
                timerLabel.Text = timerText;

                if (message.Text == "") File.WriteAllText(_filePath, timerText);
                else File.WriteAllText(_filePath, $"{message.Text} {timerText}");
            }

            else _endTime = null;
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "Start")
            {
                if (endTimePicker.Value > _currentTime)
                {
                    _endTime = endTimePicker.Value;
                    UpdateTimer();
                    startStopButton.Text = "Stop";
                    endTimePicker.Enabled = false;
                }

                else MessageBox.Show("Countdown end time must be after current time.", "Invalid time input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                _endTime = null;
                UpdateTimer();
                startStopButton.Text = "Start";
                endTimePicker.Enabled = true;
            }
        }
    }
}
