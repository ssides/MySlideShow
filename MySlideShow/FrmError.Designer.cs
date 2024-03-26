namespace MySlideShow
{
    partial class FrmError
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
            pnlError = new Panel();
            txtMessage = new TextBox();
            pnlError.SuspendLayout();
            SuspendLayout();
            // 
            // pnlError
            // 
            pnlError.Controls.Add(txtMessage);
            pnlError.Dock = DockStyle.Fill;
            pnlError.Location = new Point(0, 0);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(532, 179);
            pnlError.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 12);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(505, 152);
            txtMessage.TabIndex = 0;
            // 
            // FrmError
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 179);
            Controls.Add(pnlError);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmError";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            pnlError.ResumeLayout(false);
            pnlError.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlError;
        private TextBox txtMessage;
    }
}