namespace MidtermsTP
{
    partial class FrmTrackThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Maroon;
            lblStatus.Location = new Point(65, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(135, 18);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "- Thread Status-";
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Maroon;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.ForeColor = SystemColors.ButtonHighlight;
            btnRun.Location = new Point(95, 96);
            btnRun.Margin = new Padding(3, 2, 3, 2);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 31);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(262, 174);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTrackThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
