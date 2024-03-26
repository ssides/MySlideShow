namespace MySlideShow
{
    partial class FrmInit
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
            pnlInit = new Panel();
            cbAllowDelete = new CheckBox();
            btnClearReviewedFiles = new Button();
            cbShowPath = new CheckBox();
            cbRecurseFolders = new CheckBox();
            txtPath = new TextBox();
            label1 = new Label();
            btnReviewFiles = new Button();
            btnSlideShow = new Button();
            pnlInit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInit
            // 
            pnlInit.Controls.Add(cbAllowDelete);
            pnlInit.Controls.Add(btnClearReviewedFiles);
            pnlInit.Controls.Add(cbShowPath);
            pnlInit.Controls.Add(cbRecurseFolders);
            pnlInit.Controls.Add(txtPath);
            pnlInit.Controls.Add(label1);
            pnlInit.Controls.Add(btnReviewFiles);
            pnlInit.Controls.Add(btnSlideShow);
            pnlInit.Dock = DockStyle.Fill;
            pnlInit.Location = new Point(0, 0);
            pnlInit.Name = "pnlInit";
            pnlInit.Size = new Size(643, 196);
            pnlInit.TabIndex = 0;
            // 
            // cbAllowDelete
            // 
            cbAllowDelete.AutoSize = true;
            cbAllowDelete.Location = new Point(248, 93);
            cbAllowDelete.Name = "cbAllowDelete";
            cbAllowDelete.Size = new Size(222, 24);
            cbAllowDelete.TabIndex = 7;
            cbAllowDelete.Text = "Allow delete when reviewing";
            cbAllowDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearReviewedFiles
            // 
            btnClearReviewedFiles.Location = new Point(361, 141);
            btnClearReviewedFiles.Name = "btnClearReviewedFiles";
            btnClearReviewedFiles.Size = new Size(216, 29);
            btnClearReviewedFiles.TabIndex = 6;
            btnClearReviewedFiles.Text = "Clear Reviewed Files List";
            btnClearReviewedFiles.UseVisualStyleBackColor = true;
            btnClearReviewedFiles.Click += btnClearReviewedFiles_Click;
            // 
            // cbShowPath
            // 
            cbShowPath.AutoSize = true;
            cbShowPath.Location = new Point(65, 93);
            cbShowPath.Name = "cbShowPath";
            cbShowPath.Size = new Size(147, 24);
            cbShowPath.TabIndex = 5;
            cbShowPath.Text = "Show image path";
            cbShowPath.UseVisualStyleBackColor = true;
            // 
            // cbRecurseFolders
            // 
            cbRecurseFolders.AutoSize = true;
            cbRecurseFolders.Location = new Point(426, 42);
            cbRecurseFolders.Name = "cbRecurseFolders";
            cbRecurseFolders.Size = new Size(176, 24);
            cbRecurseFolders.TabIndex = 4;
            cbRecurseFolders.Text = "Include subdirectories";
            cbRecurseFolders.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(65, 40);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(318, 27);
            txtPath.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Path:";
            // 
            // btnReviewFiles
            // 
            btnReviewFiles.Location = new Point(193, 141);
            btnReviewFiles.Name = "btnReviewFiles";
            btnReviewFiles.Size = new Size(146, 29);
            btnReviewFiles.TabIndex = 1;
            btnReviewFiles.Text = "&Review images";
            btnReviewFiles.UseVisualStyleBackColor = true;
            btnReviewFiles.Click += btnReviewFiles_Click;
            // 
            // btnSlideShow
            // 
            btnSlideShow.Location = new Point(31, 141);
            btnSlideShow.Name = "btnSlideShow";
            btnSlideShow.Size = new Size(146, 29);
            btnSlideShow.TabIndex = 0;
            btnSlideShow.Text = "&Slide show";
            btnSlideShow.UseVisualStyleBackColor = true;
            btnSlideShow.Click += btnSlideShow_Click;
            // 
            // FrmInit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 196);
            Controls.Add(pnlInit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInit";
            Text = "Set up";
            FormClosing += FrmInit_FormClosing;
            pnlInit.ResumeLayout(false);
            pnlInit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInit;
        private CheckBox cbShowPath;
        private CheckBox cbRecurseFolders;
        private TextBox txtPath;
        private Label label1;
        private Button btnReviewFiles;
        private Button btnSlideShow;
        private Button btnClearReviewedFiles;
        private CheckBox cbAllowDelete;
    }
}