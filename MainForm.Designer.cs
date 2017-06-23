namespace DF_FaceTracking.cs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.colorResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Live = new System.Windows.Forms.ToolStripMenuItem();
            this.Playback = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Status2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AlertsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Scale = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.PictureBox();
            this.Recognition = new System.Windows.Forms.CheckBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.UnregisterUser = new System.Windows.Forms.Button();
            this.NumDetectionText = new System.Windows.Forms.TextBox();
            this.NumLandmarksText = new System.Windows.Forms.TextBox();
            this.NumPoseText = new System.Windows.Forms.TextBox();
            this.NumExpressionsText = new System.Windows.Forms.TextBox();
            this.Detection = new System.Windows.Forms.CheckBox();
            this.Landmarks = new System.Windows.Forms.CheckBox();
            this.Pose = new System.Windows.Forms.CheckBox();
            this.Expressions = new System.Windows.Forms.CheckBox();
            this.Pulse = new System.Windows.Forms.CheckBox();
            this.NumPulseText = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.Status2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(1230, 312);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 32);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(1230, 352);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(120, 32);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.sourceToolStripMenuItem.Text = "Device";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.colorResolutionToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.ProfileToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(1412, 34);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // colorResolutionToolStripMenuItem
            // 
            this.colorResolutionToolStripMenuItem.Name = "colorResolutionToolStripMenuItem";
            this.colorResolutionToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.colorResolutionToolStripMenuItem.Text = "Color";
            // 
            // ProfileToolStripMenuItem
            // 
            this.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem";
            this.ProfileToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.ProfileToolStripMenuItem.Text = "Profile";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Live,
            this.Playback,
            this.Record});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // Live
            // 
            this.Live.Checked = true;
            this.Live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(170, 30);
            this.Live.Text = "Live";
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // Playback
            // 
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(170, 30);
            this.Playback.Text = "Playback";
            this.Playback.Click += new System.EventHandler(this.Playback_Click);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(170, 30);
            this.Record.Text = "Record";
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Status2
            // 
            this.Status2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Status2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.AlertsLabel});
            this.Status2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Status2.Location = new System.Drawing.Point(0, 665);
            this.Status2.Name = "Status2";
            this.Status2.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.Status2.Size = new System.Drawing.Size(1412, 29);
            this.Status2.TabIndex = 25;
            this.Status2.Text = "Status2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.StatusLabel.Size = new System.Drawing.Size(86, 24);
            this.StatusLabel.Text = "OK";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlertsLabel
            // 
            this.AlertsLabel.AutoSize = false;
            this.AlertsLabel.Name = "AlertsLabel";
            this.AlertsLabel.Size = new System.Drawing.Size(200, 15);
            this.AlertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scale
            // 
            this.Scale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale.AutoSize = true;
            this.Scale.Checked = true;
            this.Scale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Scale.Location = new System.Drawing.Point(1231, 37);
            this.Scale.Margin = new System.Windows.Forms.Padding(4);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(79, 22);
            this.Scale.TabIndex = 26;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.ErrorImage = null;
            this.Panel2.InitialImage = null;
            this.Panel2.Location = new System.Drawing.Point(18, 37);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1201, 613);
            this.Panel2.TabIndex = 27;
            this.Panel2.TabStop = false;
            this.Panel2.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // Recognition
            // 
            this.Recognition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Recognition.AutoSize = true;
            this.Recognition.Location = new System.Drawing.Point(1221, 260);
            this.Recognition.Margin = new System.Windows.Forms.Padding(4);
            this.Recognition.Name = "Recognition";
            this.Recognition.Size = new System.Drawing.Size(133, 22);
            this.Recognition.TabIndex = 33;
            this.Recognition.Text = "Recognition";
            this.Recognition.UseVisualStyleBackColor = true;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterUser.Enabled = false;
            this.RegisterUser.Location = new System.Drawing.Point(1230, 392);
            this.RegisterUser.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(120, 32);
            this.RegisterUser.TabIndex = 34;
            this.RegisterUser.Text = "Register";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // UnregisterUser
            // 
            this.UnregisterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnregisterUser.Enabled = false;
            this.UnregisterUser.Location = new System.Drawing.Point(1230, 432);
            this.UnregisterUser.Margin = new System.Windows.Forms.Padding(4);
            this.UnregisterUser.Name = "UnregisterUser";
            this.UnregisterUser.Size = new System.Drawing.Size(120, 32);
            this.UnregisterUser.TabIndex = 35;
            this.UnregisterUser.Text = "Unregister";
            this.UnregisterUser.UseVisualStyleBackColor = true;
            this.UnregisterUser.Click += new System.EventHandler(this.UnregisterUser_Click);
            // 
            // NumDetectionText
            // 
            this.NumDetectionText.AccessibleName = "";
            this.NumDetectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumDetectionText.Location = new System.Drawing.Point(1359, 101);
            this.NumDetectionText.Margin = new System.Windows.Forms.Padding(4);
            this.NumDetectionText.Name = "NumDetectionText";
            this.NumDetectionText.Size = new System.Drawing.Size(30, 28);
            this.NumDetectionText.TabIndex = 36;
            // 
            // NumLandmarksText
            // 
            this.NumLandmarksText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumLandmarksText.Location = new System.Drawing.Point(1359, 133);
            this.NumLandmarksText.Margin = new System.Windows.Forms.Padding(4);
            this.NumLandmarksText.Name = "NumLandmarksText";
            this.NumLandmarksText.Size = new System.Drawing.Size(30, 28);
            this.NumLandmarksText.TabIndex = 37;
            // 
            // NumPoseText
            // 
            this.NumPoseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumPoseText.Location = new System.Drawing.Point(1359, 165);
            this.NumPoseText.Margin = new System.Windows.Forms.Padding(4);
            this.NumPoseText.Name = "NumPoseText";
            this.NumPoseText.Size = new System.Drawing.Size(30, 28);
            this.NumPoseText.TabIndex = 38;
            // 
            // NumExpressionsText
            // 
            this.NumExpressionsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumExpressionsText.Location = new System.Drawing.Point(1359, 197);
            this.NumExpressionsText.Margin = new System.Windows.Forms.Padding(4);
            this.NumExpressionsText.Name = "NumExpressionsText";
            this.NumExpressionsText.Size = new System.Drawing.Size(30, 28);
            this.NumExpressionsText.TabIndex = 45;
            // 
            // Detection
            // 
            this.Detection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detection.AutoSize = true;
            this.Detection.Location = new System.Drawing.Point(1223, 101);
            this.Detection.Margin = new System.Windows.Forms.Padding(4);
            this.Detection.Name = "Detection";
            this.Detection.Size = new System.Drawing.Size(115, 22);
            this.Detection.TabIndex = 46;
            this.Detection.Text = "Detection";
            this.Detection.UseVisualStyleBackColor = true;
            // 
            // Landmarks
            // 
            this.Landmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Landmarks.AutoSize = true;
            this.Landmarks.Location = new System.Drawing.Point(1232, 133);
            this.Landmarks.Margin = new System.Windows.Forms.Padding(4);
            this.Landmarks.Name = "Landmarks";
            this.Landmarks.Size = new System.Drawing.Size(115, 22);
            this.Landmarks.TabIndex = 47;
            this.Landmarks.Text = "Landmarks";
            this.Landmarks.UseVisualStyleBackColor = true;
            // 
            // Pose
            // 
            this.Pose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pose.AutoSize = true;
            this.Pose.Location = new System.Drawing.Point(1235, 165);
            this.Pose.Margin = new System.Windows.Forms.Padding(4);
            this.Pose.Name = "Pose";
            this.Pose.Size = new System.Drawing.Size(70, 22);
            this.Pose.TabIndex = 48;
            this.Pose.Text = "Pose";
            this.Pose.UseVisualStyleBackColor = true;
            // 
            // Expressions
            // 
            this.Expressions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expressions.AutoSize = true;
            this.Expressions.Location = new System.Drawing.Point(1220, 197);
            this.Expressions.Margin = new System.Windows.Forms.Padding(4);
            this.Expressions.Name = "Expressions";
            this.Expressions.Size = new System.Drawing.Size(133, 22);
            this.Expressions.TabIndex = 49;
            this.Expressions.Text = "Expressions";
            this.Expressions.UseVisualStyleBackColor = true;
            // 
            // Pulse
            // 
            this.Pulse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pulse.AutoSize = true;
            this.Pulse.Location = new System.Drawing.Point(1229, 228);
            this.Pulse.Margin = new System.Windows.Forms.Padding(4);
            this.Pulse.Name = "Pulse";
            this.Pulse.Size = new System.Drawing.Size(79, 22);
            this.Pulse.TabIndex = 51;
            this.Pulse.Text = "Pulse";
            this.Pulse.UseVisualStyleBackColor = true;
            // 
            // NumPulseText
            // 
            this.NumPulseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumPulseText.Location = new System.Drawing.Point(1359, 228);
            this.NumPulseText.Margin = new System.Windows.Forms.Padding(4);
            this.NumPulseText.Name = "NumPulseText";
            this.NumPulseText.Size = new System.Drawing.Size(30, 28);
            this.NumPulseText.TabIndex = 52;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1412, 694);
            this.Controls.Add(this.NumPulseText);
            this.Controls.Add(this.Pulse);
            this.Controls.Add(this.Expressions);
            this.Controls.Add(this.Pose);
            this.Controls.Add(this.Landmarks);
            this.Controls.Add(this.Detection);
            this.Controls.Add(this.NumExpressionsText);
            this.Controls.Add(this.NumPoseText);
            this.Controls.Add(this.NumLandmarksText);
            this.Controls.Add(this.NumDetectionText);
            this.Controls.Add(this.UnregisterUser);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.Recognition);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Intel(R) RealSense(TM) SDK: Face Tracking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status2.ResumeLayout(false);
            this.Status2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip Status2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private new System.Windows.Forms.CheckBox Scale;
        private System.Windows.Forms.PictureBox Panel2;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Live;
        private System.Windows.Forms.ToolStripMenuItem Playback;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.ToolStripMenuItem ProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel AlertsLabel;
        private System.Windows.Forms.CheckBox Recognition;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.Button UnregisterUser;
        private System.Windows.Forms.ToolStripMenuItem colorResolutionToolStripMenuItem;
        private System.Windows.Forms.TextBox NumDetectionText;
        private System.Windows.Forms.TextBox NumLandmarksText;
        private System.Windows.Forms.TextBox NumPoseText;
        private System.Windows.Forms.TextBox NumExpressionsText;
        private System.Windows.Forms.CheckBox Detection;
        private System.Windows.Forms.CheckBox Landmarks;
        private System.Windows.Forms.CheckBox Pose;
        private System.Windows.Forms.CheckBox Expressions;
        //private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.CheckBox Pulse;
        private System.Windows.Forms.TextBox NumPulseText;
    }
}