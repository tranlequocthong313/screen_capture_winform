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
            newButton = new Button();
            label1 = new Label();
            screenShotPictureBox = new PictureBox();
            panel1 = new Panel();
            saveScreenShotButton = new Button();
            ((System.ComponentModel.ISupportInitialize)screenShotPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // newButton
            // 
            newButton.BackColor = Color.FromArgb(64, 64, 64);
            newButton.BackgroundImageLayout = ImageLayout.Zoom;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Popup;
            newButton.ForeColor = Color.White;
            newButton.ImageAlign = ContentAlignment.MiddleLeft;
            newButton.Location = new Point(27, 12);
            newButton.Name = "newButton";
            newButton.Size = new Size(123, 52);
            newButton.TabIndex = 0;
            newButton.Text = "+ NEW";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 155);
            label1.Name = "label1";
            label1.Size = new Size(478, 28);
            label1.TabIndex = 1;
            label1.Text = "Press Windows logo key + Shift + Z to start a snip.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // screenShotPictureBox
            // 
            screenShotPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screenShotPictureBox.Location = new Point(47, 88);
            screenShotPictureBox.Name = "screenShotPictureBox";
            screenShotPictureBox.Size = new Size(637, 189);
            screenShotPictureBox.TabIndex = 2;
            screenShotPictureBox.TabStop = false;
            screenShotPictureBox.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(saveScreenShotButton);
            panel1.Controls.Add(newButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 82);
            panel1.TabIndex = 3;
            // 
            // saveScreenShotButton
            // 
            saveScreenShotButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveScreenShotButton.BackColor = Color.Transparent;
            saveScreenShotButton.BackgroundImage = Properties.Resources.diskette;
            saveScreenShotButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveScreenShotButton.FlatAppearance.BorderSize = 0;
            saveScreenShotButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            saveScreenShotButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            saveScreenShotButton.FlatStyle = FlatStyle.Flat;
            saveScreenShotButton.ForeColor = Color.Transparent;
            saveScreenShotButton.Location = new Point(658, 12);
            saveScreenShotButton.Name = "saveScreenShotButton";
            saveScreenShotButton.Size = new Size(43, 52);
            saveScreenShotButton.TabIndex = 1;
            saveScreenShotButton.UseVisualStyleBackColor = false;
            saveScreenShotButton.Visible = false;
            saveScreenShotButton.Click += saveScreenShotButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(730, 289);
            Controls.Add(panel1);
            Controls.Add(screenShotPictureBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            IsMdiContainer = true;
            Name = "Main";
            Text = "Snipping Tool";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)screenShotPictureBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button newButton;
        private Label label1;
        private PictureBox screenShotPictureBox;
        private Panel panel1;
        private Button saveScreenShotButton;
    }
}