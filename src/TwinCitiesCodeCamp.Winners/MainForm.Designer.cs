namespace TwinCitiesCodeCamp.Winners
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            siteImage = new PictureBox();
            pickWinner = new Button();
            currentWinner = new Label();
            label1 = new Label();
            attendeeList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)siteImage).BeginInit();
            SuspendLayout();
            // 
            // siteImage
            // 
            siteImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            siteImage.Image = (Image)resources.GetObject("siteImage.Image");
            siteImage.Location = new Point(22, 20);
            siteImage.Margin = new Padding(5);
            siteImage.Name = "siteImage";
            siteImage.Size = new Size(901, 188);
            siteImage.SizeMode = PictureBoxSizeMode.Zoom;
            siteImage.TabIndex = 0;
            siteImage.TabStop = false;
            // 
            // pickWinner
            // 
            pickWinner.Location = new Point(22, 235);
            pickWinner.Margin = new Padding(5);
            pickWinner.Name = "pickWinner";
            pickWinner.Size = new Size(172, 38);
            pickWinner.TabIndex = 1;
            pickWinner.Text = "Pick Winner";
            pickWinner.UseVisualStyleBackColor = true;
            pickWinner.Click += OnPickWinnerClick;
            // 
            // currentWinner
            // 
            currentWinner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentWinner.BorderStyle = BorderStyle.FixedSingle;
            currentWinner.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            currentWinner.ForeColor = Color.White;
            currentWinner.Location = new Point(22, 288);
            currentWinner.Name = "currentWinner";
            currentWinner.Size = new Size(901, 63);
            currentWinner.TabIndex = 2;
            currentWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 367);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "Attendees:";
            // 
            // attendeeList
            // 
            attendeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            attendeeList.FormattingEnabled = true;
            attendeeList.ItemHeight = 25;
            attendeeList.Location = new Point(22, 395);
            attendeeList.Name = "attendeeList";
            attendeeList.Size = new Size(901, 254);
            attendeeList.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 62, 80);
            ClientSize = new Size(948, 669);
            Controls.Add(attendeeList);
            Controls.Add(label1);
            Controls.Add(currentWinner);
            Controls.Add(pickWinner);
            Controls.Add(siteImage);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Twin Cities Code Camp Winners!";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)siteImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox siteImage;
        private Button pickWinner;
        private Label currentWinner;
        private Label label1;
        private ListBox attendeeList;
    }
}