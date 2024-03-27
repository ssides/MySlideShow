namespace MySlideShow
{
    partial class FrmReviewImages
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
            frmLayout = new TableLayoutPanel();
            ctrlLayout = new TableLayoutPanel();
            pnlPath = new Panel();
            txtPath = new TextBox();
            pnlControl = new Panel();
            btnUndo = new Button();
            btnRotate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            txtMessages = new TextBox();
            pbImage = new PictureBox();
            frmLayout.SuspendLayout();
            ctrlLayout.SuspendLayout();
            pnlPath.SuspendLayout();
            pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // frmLayout
            // 
            frmLayout.ColumnCount = 1;
            frmLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            frmLayout.Controls.Add(ctrlLayout, 0, 1);
            frmLayout.Controls.Add(txtMessages, 0, 2);
            frmLayout.Controls.Add(pbImage, 0, 0);
            frmLayout.Dock = DockStyle.Fill;
            frmLayout.Location = new Point(0, 0);
            frmLayout.Name = "frmLayout";
            frmLayout.RowCount = 3;
            frmLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            frmLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            frmLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            frmLayout.Size = new Size(800, 450);
            frmLayout.TabIndex = 0;
            // 
            // ctrlLayout
            // 
            ctrlLayout.ColumnCount = 2;
            ctrlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 305F));
            ctrlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ctrlLayout.Controls.Add(pnlPath, 1, 0);
            ctrlLayout.Controls.Add(pnlControl, 0, 0);
            ctrlLayout.Dock = DockStyle.Fill;
            ctrlLayout.Location = new Point(3, 254);
            ctrlLayout.Name = "ctrlLayout";
            ctrlLayout.RowCount = 1;
            ctrlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ctrlLayout.Size = new Size(794, 43);
            ctrlLayout.TabIndex = 0;
            // 
            // pnlPath
            // 
            pnlPath.Controls.Add(txtPath);
            pnlPath.Dock = DockStyle.Fill;
            pnlPath.Location = new Point(308, 3);
            pnlPath.Name = "pnlPath";
            pnlPath.Size = new Size(483, 37);
            pnlPath.TabIndex = 0;
            // 
            // txtPath
            // 
            txtPath.Dock = DockStyle.Fill;
            txtPath.Location = new Point(0, 0);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(483, 27);
            txtPath.TabIndex = 0;
            txtPath.Leave += txtPath_Leave;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnUndo);
            pnlControl.Controls.Add(btnRotate);
            pnlControl.Controls.Add(btnSave);
            pnlControl.Controls.Add(btnDelete);
            pnlControl.Dock = DockStyle.Fill;
            pnlControl.Location = new Point(3, 3);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(299, 37);
            pnlControl.TabIndex = 1;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(224, 2);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(68, 29);
            btnUndo.TabIndex = 3;
            btnUndo.Text = "&Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(150, 2);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(68, 29);
            btnRotate.TabIndex = 2;
            btnRotate.Text = "&Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(76, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(68, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtMessages
            // 
            txtMessages.Dock = DockStyle.Fill;
            txtMessages.Location = new Point(3, 303);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.Size = new Size(794, 144);
            txtMessages.TabIndex = 1;
            txtMessages.WordWrap = false;
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(3, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(794, 245);
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            pbImage.SizeChanged += pbImage_SizeChanged;
            pbImage.DoubleClick += pbImage_DoubleClick;
            // 
            // FrmReviewImages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(frmLayout);
            Name = "FrmReviewImages";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Review Files";
            FormClosing += FrmReviewImages_FormClosing;
            frmLayout.ResumeLayout(false);
            frmLayout.PerformLayout();
            ctrlLayout.ResumeLayout(false);
            pnlPath.ResumeLayout(false);
            pnlPath.PerformLayout();
            pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel frmLayout;
        private TableLayoutPanel ctrlLayout;
        private Panel pnlPath;
        private TextBox txtPath;
        private Panel pnlControl;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtMessages;
        private PictureBox pbImage;
        private Button btnRotate;
        private Button btnUndo;
    }
}