namespace ScreenCapture
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            newButton = new Button();
            guideLabel = new Label();
            screenShotPictureBox = new PictureBox();
            panel1 = new Panel();
            saveButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)screenShotPictureBox).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // newButton
            // 
            newButton.BackColor = Color.FromArgb(231, 151, 66);
            newButton.BackgroundImageLayout = ImageLayout.Zoom;
            newButton.Cursor = Cursors.Hand;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Popup;
            newButton.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            newButton.ForeColor = Color.Black;
            newButton.ImageAlign = ContentAlignment.MiddleLeft;
            newButton.Location = new Point(44, 27);
            newButton.Name = "newButton";
            newButton.Size = new Size(123, 52);
            newButton.TabIndex = 0;
            newButton.Text = "NEW";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // guideLabel
            // 
            guideLabel.Anchor = AnchorStyles.None;
            guideLabel.AutoSize = true;
            guideLabel.ForeColor = Color.Black;
            guideLabel.Location = new Point(136, 158);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(472, 28);
            guideLabel.TabIndex = 1;
            guideLabel.Text = "Press Windows logo key+ Shift + Z to start a snip.";
            guideLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // screenShotPictureBox
            // 
            screenShotPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screenShotPictureBox.Location = new Point(34, 88);
            screenShotPictureBox.Name = "screenShotPictureBox";
            screenShotPictureBox.Size = new Size(662, 189);
            screenShotPictureBox.TabIndex = 2;
            screenShotPictureBox.TabStop = false;
            screenShotPictureBox.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(newButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 82);
            panel1.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(231, 151, 66);
            saveButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.Black;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(184, 27);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 52);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveScreenShotButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Screen Capture";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(112, 36);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(111, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 213, 216);
            ClientSize = new Size(730, 289);
            Controls.Add(panel1);
            Controls.Add(screenShotPictureBox);
            Controls.Add(guideLabel);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Screen Capture";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)screenShotPictureBox).EndInit();
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button newButton;
        private Label guideLabel;
        private PictureBox screenShotPictureBox;
        private Panel panel1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button saveButton;
    }
}