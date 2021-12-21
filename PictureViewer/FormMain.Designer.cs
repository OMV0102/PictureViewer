
namespace PictureViewer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.изToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomOnOff = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoom100 = new System.Windows.Forms.Button();
            this.btnFlipVertically = new System.Windows.Forms.Button();
            this.btnFlipHorizontally = new System.Windows.Forms.Button();
            this.btnRotateClockWise = new System.Windows.Forms.Button();
            this.btnRotateCounterClockWise = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изToolStripMenuItem,
            this.авторыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // изToolStripMenuItem
            // 
            this.изToolStripMenuItem.Name = "изToolStripMenuItem";
            this.изToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.изToolStripMenuItem.Text = "Редактор";
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.авторыToolStripMenuItem.Text = "Авторы";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnZoomOut, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomOnOff, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomIn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnZoom100, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFlipVertically, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFlipHorizontally, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRotateClockWise, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRotateCounterClockWise, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 518);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::PictureViewer.Properties.Resources.ZoomOut;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(682, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(97, 51);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomOnOff
            // 
            this.btnZoomOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOnOff.Location = new System.Drawing.Point(391, 3);
            this.btnZoomOnOff.Name = "btnZoomOnOff";
            this.btnZoomOnOff.Size = new System.Drawing.Size(91, 51);
            this.btnZoomOnOff.TabIndex = 6;
            this.btnZoomOnOff.TabStop = false;
            this.btnZoomOnOff.Text = "Вкл.\r\nZoom";
            this.btnZoomOnOff.UseVisualStyleBackColor = true;
            this.btnZoomOnOff.Click += new System.EventHandler(this.btnZoomOnOff_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackgroundImage = global::PictureViewer.Properties.Resources.ZoomIn;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.Location = new System.Drawing.Point(585, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(91, 51);
            this.btnZoomIn.TabIndex = 5;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.BackgroundImage = global::PictureViewer.Properties.Resources.size100;
            this.btnZoom100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoom100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoom100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoom100.Location = new System.Drawing.Point(488, 3);
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(91, 51);
            this.btnZoom100.TabIndex = 4;
            this.btnZoom100.TabStop = false;
            this.btnZoom100.UseVisualStyleBackColor = true;
            this.btnZoom100.Click += new System.EventHandler(this.btnZoom100_Click);
            // 
            // btnFlipVertically
            // 
            this.btnFlipVertically.BackgroundImage = global::PictureViewer.Properties.Resources.Vertically;
            this.btnFlipVertically.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlipVertically.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlipVertically.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlipVertically.Location = new System.Drawing.Point(294, 3);
            this.btnFlipVertically.Name = "btnFlipVertically";
            this.btnFlipVertically.Size = new System.Drawing.Size(91, 51);
            this.btnFlipVertically.TabIndex = 3;
            this.btnFlipVertically.TabStop = false;
            this.btnFlipVertically.UseVisualStyleBackColor = true;
            this.btnFlipVertically.Click += new System.EventHandler(this.btnFlipVertically_Click);
            // 
            // btnFlipHorizontally
            // 
            this.btnFlipHorizontally.BackgroundImage = global::PictureViewer.Properties.Resources.Horizontally;
            this.btnFlipHorizontally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlipHorizontally.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlipHorizontally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlipHorizontally.Location = new System.Drawing.Point(197, 3);
            this.btnFlipHorizontally.Name = "btnFlipHorizontally";
            this.btnFlipHorizontally.Size = new System.Drawing.Size(91, 51);
            this.btnFlipHorizontally.TabIndex = 2;
            this.btnFlipHorizontally.TabStop = false;
            this.btnFlipHorizontally.UseVisualStyleBackColor = true;
            this.btnFlipHorizontally.Click += new System.EventHandler(this.btnFlipHorizontally_Click);
            // 
            // btnRotateClockWise
            // 
            this.btnRotateClockWise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateClockWise.BackgroundImage")));
            this.btnRotateClockWise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateClockWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotateClockWise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRotateClockWise.Location = new System.Drawing.Point(100, 3);
            this.btnRotateClockWise.Name = "btnRotateClockWise";
            this.btnRotateClockWise.Size = new System.Drawing.Size(91, 51);
            this.btnRotateClockWise.TabIndex = 1;
            this.btnRotateClockWise.TabStop = false;
            this.btnRotateClockWise.UseVisualStyleBackColor = true;
            this.btnRotateClockWise.Click += new System.EventHandler(this.btnRotateClockWise_Click);
            // 
            // btnRotateCounterClockWise
            // 
            this.btnRotateCounterClockWise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateCounterClockWise.BackgroundImage")));
            this.btnRotateCounterClockWise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateCounterClockWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotateCounterClockWise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRotateCounterClockWise.Location = new System.Drawing.Point(3, 3);
            this.btnRotateCounterClockWise.Name = "btnRotateCounterClockWise";
            this.btnRotateCounterClockWise.Size = new System.Drawing.Size(91, 51);
            this.btnRotateCounterClockWise.TabIndex = 0;
            this.btnRotateCounterClockWise.TabStop = false;
            this.btnRotateCounterClockWise.UseVisualStyleBackColor = true;
            this.btnRotateCounterClockWise.Click += new System.EventHandler(this.btnRotateCounterClockWise_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.ErrorImage = global::PictureViewer.Properties.Resources.NoImage;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = global::PictureViewer.Properties.Resources.DefaultImage;
            this.pictureBox.Location = new System.Drawing.Point(1, 27);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(782, 493);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem изToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRotateCounterClockWise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomOnOff;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoom100;
        private System.Windows.Forms.Button btnFlipVertically;
        private System.Windows.Forms.Button btnFlipHorizontally;
        private System.Windows.Forms.Button btnRotateClockWise;
    }
}