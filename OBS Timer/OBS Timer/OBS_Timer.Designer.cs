
namespace OBS_Timer
{
    partial class Timer_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.clockBox = new System.Windows.Forms.GroupBox();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timerBox = new System.Windows.Forms.GroupBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.endTimeBox = new System.Windows.Forms.GroupBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageBox = new System.Windows.Forms.GroupBox();
            this.message = new System.Windows.Forms.TextBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.clockBox.SuspendLayout();
            this.timerBox.SuspendLayout();
            this.endTimeBox.SuspendLayout();
            this.messageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // clockBox
            // 
            this.clockBox.Controls.Add(this.clockLabel);
            this.clockBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockBox.Location = new System.Drawing.Point(12, 12);
            this.clockBox.Name = "clockBox";
            this.clockBox.Size = new System.Drawing.Size(371, 75);
            this.clockBox.TabIndex = 0;
            this.clockBox.TabStop = false;
            this.clockBox.Text = "Current Time";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockLabel.Location = new System.Drawing.Point(6, 19);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(359, 37);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "01/01/9999 12:34:56";
            // 
            // timerBox
            // 
            this.timerBox.Controls.Add(this.timerLabel);
            this.timerBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerBox.Location = new System.Drawing.Point(12, 256);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(227, 75);
            this.timerBox.TabIndex = 1;
            this.timerBox.TabStop = false;
            this.timerBox.Text = "Countdown";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(6, 19);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(215, 37);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00:00:00";
            // 
            // endTimeBox
            // 
            this.endTimeBox.Controls.Add(this.endTimePicker);
            this.endTimeBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endTimeBox.Location = new System.Drawing.Point(12, 93);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(371, 75);
            this.endTimeBox.TabIndex = 2;
            this.endTimeBox.TabStop = false;
            this.endTimeBox.Text = "Countdown To:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(6, 22);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(358, 32);
            this.endTimePicker.TabIndex = 0;
            this.endTimePicker.Value = new System.DateTime(2020, 12, 4, 0, 0, 0, 0);
            // 
            // messageBox
            // 
            this.messageBox.Controls.Add(this.message);
            this.messageBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageBox.Location = new System.Drawing.Point(12, 175);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(371, 75);
            this.messageBox.TabIndex = 3;
            this.messageBox.TabStop = false;
            this.messageBox.Text = "Message";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message.Location = new System.Drawing.Point(7, 23);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(357, 33);
            this.message.TabIndex = 0;
            this.message.Text = "Time Left:";
            // 
            // startStopButton
            // 
            this.startStopButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startStopButton.Location = new System.Drawing.Point(245, 256);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(138, 75);
            this.startStopButton.TabIndex = 4;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // Timer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 343);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.endTimeBox);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.clockBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Timer_Form";
            this.Text = "OBS Timer";
            this.clockBox.ResumeLayout(false);
            this.clockBox.PerformLayout();
            this.timerBox.ResumeLayout(false);
            this.timerBox.PerformLayout();
            this.endTimeBox.ResumeLayout(false);
            this.messageBox.ResumeLayout(false);
            this.messageBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.GroupBox clockBox;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.GroupBox timerBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.GroupBox endTimeBox;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.GroupBox messageBox;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button startStopButton;
    }
}

