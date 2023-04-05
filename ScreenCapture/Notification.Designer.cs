namespace ScreenCapture
{
    partial class Notification
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            closeButton = new Button();
            label3 = new Label();
            label2 = new Label();
            icon = new PictureBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 151, 66);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(icon);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 160);
            panel1.TabIndex = 0;
            panel1.Click += Notification_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImage = Properties.Resources.close;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(231, 151, 66);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.Transparent;
            closeButton.Location = new Point(463, 35);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(15, 15);
            closeButton.TabIndex = 4;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 3;
            label3.Text = "Select here to see";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(393, 28);
            label2.TabIndex = 2;
            label2.Text = "Screenshot copied to clipboard and saved";
            // 
            // icon
            // 
            icon.Image = Properties.Resources.g12_snipping_97305;
            icon.Location = new Point(30, 28);
            icon.Name = "icon";
            icon.Size = new Size(32, 32);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 1;
            icon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 35);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 0;
            label1.Text = "Screen Capture";
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(517, 284);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Click += Notification_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 213, 216);
            ClientSize = new Size(517, 444);
            ControlBox = false;
            Controls.Add(pictureBox);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Notification";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Notification";
            TopMost = true;
            Click += Notification_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox icon;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private Button closeButton;
    }
}