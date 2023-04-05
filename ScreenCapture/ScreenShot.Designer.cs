namespace ScreenCapture
{
    partial class ScreenShot
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
            popUpControlsPanel = new Panel();
            takeScreenShotButton = new Button();
            closeButton = new Button();
            popUpControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // popUpControlsPanel
            // 
            popUpControlsPanel.Anchor = AnchorStyles.Top;
            popUpControlsPanel.BackColor = Color.Transparent;
            popUpControlsPanel.Controls.Add(takeScreenShotButton);
            popUpControlsPanel.Controls.Add(closeButton);
            popUpControlsPanel.Location = new Point(288, 12);
            popUpControlsPanel.Name = "popUpControlsPanel";
            popUpControlsPanel.Size = new Size(443, 88);
            popUpControlsPanel.TabIndex = 0;
            // 
            // takeScreenShotButton
            // 
            takeScreenShotButton.Anchor = AnchorStyles.None;
            takeScreenShotButton.BackColor = Color.FromArgb(231, 151, 66);
            takeScreenShotButton.BackgroundImageLayout = ImageLayout.None;
            takeScreenShotButton.Cursor = Cursors.Hand;
            takeScreenShotButton.FlatAppearance.BorderSize = 0;
            takeScreenShotButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            takeScreenShotButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            takeScreenShotButton.FlatStyle = FlatStyle.Popup;
            takeScreenShotButton.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            takeScreenShotButton.ForeColor = Color.Black;
            takeScreenShotButton.Location = new Point(43, 20);
            takeScreenShotButton.Name = "takeScreenShotButton";
            takeScreenShotButton.Size = new Size(161, 53);
            takeScreenShotButton.TabIndex = 1;
            takeScreenShotButton.Text = "Fullscreen";
            takeScreenShotButton.UseVisualStyleBackColor = false;
            takeScreenShotButton.Click += takeScreenShotButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.BackColor = Color.FromArgb(231, 151, 66);
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.Black;
            closeButton.Location = new Point(238, 20);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(161, 53);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // ScreenShot
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CancelButton = closeButton;
            ClientSize = new Size(1080, 444);
            ControlBox = false;
            Controls.Add(popUpControlsPanel);
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(231, 151, 66);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScreenShot";
            Opacity = 0.5D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ScreenShot";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += ScreenShot_Load;
            Paint += ScreenShot_Paint;
            MouseDown += ScreenShot_MouseDown;
            MouseMove += ScreenShot_MouseMove;
            MouseUp += ScreenShot_MouseUp;
            popUpControlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel popUpControlsPanel;
        private Button closeButton;
        private Button takeScreenShotButton;
    }
}