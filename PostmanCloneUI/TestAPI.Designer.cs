namespace PostmanCloneUI
{
    partial class TestAPI
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
            urlLabel = new Label();
            resultsLabel = new Label();
            urlText = new TextBox();
            resultsText = new TextBox();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // urlLabel
            // 
            urlLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(34, 19);
            urlLabel.Margin = new Padding(3);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(42, 21);
            urlLabel.TabIndex = 0;
            urlLabel.Text = "URL:";
            // 
            // resultsLabel
            // 
            resultsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(13, 89);
            resultsLabel.Margin = new Padding(3);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(63, 21);
            resultsLabel.TabIndex = 1;
            resultsLabel.Text = "Results:";
            // 
            // urlText
            // 
            urlText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            urlText.Location = new Point(82, 19);
            urlText.Name = "urlText";
            urlText.Size = new Size(389, 29);
            urlText.TabIndex = 2;
            // 
            // resultsText
            // 
            resultsText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultsText.Location = new Point(82, 89);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(389, 264);
            resultsText.TabIndex = 3;
            // 
            // callApi
            // 
            callApi.Location = new Point(477, 19);
            callApi.Name = "callApi";
            callApi.Size = new Size(100, 28);
            callApi.TabIndex = 4;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 378);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(580, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "StatusStrip";
            // 
            // systemStatus
            // 
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(39, 17);
            systemStatus.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.63636F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.Controls.Add(resultsText, 1, 3);
            tableLayoutPanel1.Controls.Add(urlLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(urlText, 1, 1);
            tableLayoutPanel1.Controls.Add(callApi, 2, 1);
            tableLayoutPanel1.Controls.Add(resultsLabel, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(580, 378);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // TestAPI
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 400);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TestAPI";
            Text = "TestAPI";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label urlLabel;
        private Label resultsLabel;
        private TextBox urlText;
        private TextBox resultsText;
        private Button callApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private TableLayoutPanel tableLayoutPanel1;
    }
}