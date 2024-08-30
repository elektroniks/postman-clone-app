namespace PostmanCloneUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            MenuPanel = new Panel();
            testButton = new Button();
            buttonSlide = new PictureBox();
            TitlePanel = new Panel();
            minimize = new PictureBox();
            maximize = new PictureBox();
            close = new PictureBox();
            ContentPanel = new Panel();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonSlide).BeginInit();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(0, 90, 151);
            MenuPanel.Controls.Add(testButton);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(200, 440);
            MenuPanel.TabIndex = 0;
            // 
            // testButton
            // 
            testButton.FlatAppearance.BorderSize = 0;
            testButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 124, 141);
            testButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 57, 65);
            testButton.FlatStyle = FlatStyle.Flat;
            testButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testButton.ForeColor = Color.White;
            testButton.Image = (Image)resources.GetObject("testButton.Image");
            testButton.ImageAlign = ContentAlignment.MiddleLeft;
            testButton.Location = new Point(0, 60);
            testButton.Name = "testButton";
            testButton.Size = new Size(200, 42);
            testButton.TabIndex = 0;
            testButton.Text = "Test API";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // buttonSlide
            // 
            buttonSlide.Image = (Image)resources.GetObject("buttonSlide.Image");
            buttonSlide.Location = new Point(6, 4);
            buttonSlide.Name = "buttonSlide";
            buttonSlide.Size = new Size(30, 30);
            buttonSlide.SizeMode = PictureBoxSizeMode.Zoom;
            buttonSlide.TabIndex = 0;
            buttonSlide.TabStop = false;
            buttonSlide.Click += buttonSlide_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(232, 232, 232);
            TitlePanel.Controls.Add(buttonSlide);
            TitlePanel.Controls.Add(minimize);
            TitlePanel.Controls.Add(maximize);
            TitlePanel.Controls.Add(close);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(200, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(580, 40);
            TitlePanel.TabIndex = 1;
            TitlePanel.MouseDown += TitlePanel_MouseDown;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(500, 7);
            minimize.Name = "minimize";
            minimize.Size = new Size(20, 20);
            minimize.SizeMode = PictureBoxSizeMode.Zoom;
            minimize.TabIndex = 1;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize.Image = (Image)resources.GetObject("maximize.Image");
            maximize.Location = new Point(526, 7);
            maximize.Name = "maximize";
            maximize.Size = new Size(20, 20);
            maximize.SizeMode = PictureBoxSizeMode.Zoom;
            maximize.TabIndex = 1;
            maximize.TabStop = false;
            maximize.Click += maximize_Click;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(552, 7);
            close.Name = "close";
            close.Size = new Size(20, 20);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 1;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(200, 40);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(580, 400);
            ContentPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 440);
            Controls.Add(ContentPanel);
            Controls.Add(TitlePanel);
            Controls.Add(MenuPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone";
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonSlide).EndInit();
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel TitlePanel;
        private Panel ContentPanel;
        private PictureBox buttonSlide;
        private PictureBox close;
        private PictureBox minimize;
        private PictureBox maximize;
        private Button testButton;
    }
}
