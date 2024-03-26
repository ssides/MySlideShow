namespace MySlideShow
{
    partial class FrmMySlideShow
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
            tableLayoutApp = new TableLayoutPanel();
            pnlControl = new Panel();
            btnPrev = new Button();
            btnNext = new Button();
            pbSlide = new PictureBox();
            txtFilePath = new TextBox();
            tableLayoutApp.SuspendLayout();
            pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlide).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutApp
            // 
            tableLayoutApp.ColumnCount = 1;
            tableLayoutApp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutApp.Controls.Add(pnlControl, 0, 1);
            tableLayoutApp.Controls.Add(pbSlide, 0, 0);
            tableLayoutApp.Dock = DockStyle.Fill;
            tableLayoutApp.Location = new Point(0, 0);
            tableLayoutApp.Name = "tableLayoutApp";
            tableLayoutApp.RowCount = 2;
            tableLayoutApp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutApp.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutApp.Size = new Size(800, 450);
            tableLayoutApp.TabIndex = 0;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(txtFilePath);
            pnlControl.Controls.Add(btnPrev);
            pnlControl.Controls.Add(btnNext);
            pnlControl.Dock = DockStyle.Fill;
            pnlControl.Location = new Point(3, 393);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(794, 54);
            pnlControl.TabIndex = 0;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(23, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(100, 29);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "&Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(129, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 29);
            btnNext.TabIndex = 0;
            btnNext.Text = "&Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pbSlide
            // 
            pbSlide.Dock = DockStyle.Fill;
            pbSlide.Location = new Point(3, 3);
            pbSlide.Name = "pbSlide";
            pbSlide.Size = new Size(794, 384);
            pbSlide.TabIndex = 1;
            pbSlide.TabStop = false;
            pbSlide.SizeChanged += pbSlide_SizeChanged;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(235, 13);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(514, 27);
            txtFilePath.TabIndex = 2;
            // 
            // FrmMySlideShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutApp);
            Name = "FrmMySlideShow";
            Text = "MySlideShow";
            tableLayoutApp.ResumeLayout(false);
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutApp;
        private Panel pnlControl;
        private Button btnNext;
        private Button btnPrev;
        private PictureBox pbSlide;
        private TextBox txtFilePath;
    }
}
