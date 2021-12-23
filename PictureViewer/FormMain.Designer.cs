
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveImageChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomOnOff = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnFlipVertically = new System.Windows.Forms.Button();
            this.btnFlipHorizontally = new System.Windows.Forms.Button();
            this.btnRotateClockWise = new System.Windows.Forms.Button();
            this.btnRotateCounterClockWise = new System.Windows.Forms.Button();
            this.contextMenuPictureBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuImageSaveLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddNewImage = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.contextMenuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.btnSaveImageChange});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // btnSaveImageChange
            // 
            this.btnSaveImageChange.Name = "btnSaveImageChange";
            this.btnSaveImageChange.Size = new System.Drawing.Size(166, 20);
            this.btnSaveImageChange.Text = "СОХРАНИТЬ ИЗМЕНЕНИЯ";
            this.btnSaveImageChange.Visible = false;
            this.btnSaveImageChange.Click += new System.EventHandler(this.btnSaveImageChange_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btnFlipVertically, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFlipHorizontally, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRotateClockWise, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRotateCounterClockWise, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 518);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::PictureViewer.Properties.Resources.ZoomOut;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(913, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(131, 51);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomOnOff
            // 
            this.btnZoomOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.btnZoomOnOff, 2);
            this.btnZoomOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOnOff.Location = new System.Drawing.Point(523, 3);
            this.btnZoomOnOff.Name = "btnZoomOnOff";
            this.btnZoomOnOff.Size = new System.Drawing.Size(254, 51);
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
            this.btnZoomIn.Location = new System.Drawing.Point(783, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(124, 51);
            this.btnZoomIn.TabIndex = 5;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnFlipVertically
            // 
            this.btnFlipVertically.BackgroundImage = global::PictureViewer.Properties.Resources.Vertically;
            this.btnFlipVertically.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlipVertically.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlipVertically.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlipVertically.Location = new System.Drawing.Point(393, 3);
            this.btnFlipVertically.Name = "btnFlipVertically";
            this.btnFlipVertically.Size = new System.Drawing.Size(124, 51);
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
            this.btnFlipHorizontally.Location = new System.Drawing.Point(263, 3);
            this.btnFlipHorizontally.Name = "btnFlipHorizontally";
            this.btnFlipHorizontally.Size = new System.Drawing.Size(124, 51);
            this.btnFlipHorizontally.TabIndex = 2;
            this.btnFlipHorizontally.TabStop = false;
            this.btnFlipHorizontally.UseVisualStyleBackColor = true;
            this.btnFlipHorizontally.Click += new System.EventHandler(this.btnFlipHorizontally_Click);
            // 
            // btnRotateClockWise
            // 
            this.btnRotateClockWise.BackgroundImage = global::PictureViewer.Properties.Resources.Right;
            this.btnRotateClockWise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateClockWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotateClockWise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRotateClockWise.Location = new System.Drawing.Point(133, 3);
            this.btnRotateClockWise.Name = "btnRotateClockWise";
            this.btnRotateClockWise.Size = new System.Drawing.Size(124, 51);
            this.btnRotateClockWise.TabIndex = 1;
            this.btnRotateClockWise.TabStop = false;
            this.btnRotateClockWise.UseVisualStyleBackColor = true;
            this.btnRotateClockWise.Click += new System.EventHandler(this.btnRotateClockWise_Click);
            // 
            // btnRotateCounterClockWise
            // 
            this.btnRotateCounterClockWise.BackgroundImage = global::PictureViewer.Properties.Resources.Left;
            this.btnRotateCounterClockWise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateCounterClockWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotateCounterClockWise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRotateCounterClockWise.Location = new System.Drawing.Point(3, 3);
            this.btnRotateCounterClockWise.Name = "btnRotateCounterClockWise";
            this.btnRotateCounterClockWise.Size = new System.Drawing.Size(124, 51);
            this.btnRotateCounterClockWise.TabIndex = 0;
            this.btnRotateCounterClockWise.TabStop = false;
            this.btnRotateCounterClockWise.UseVisualStyleBackColor = true;
            this.btnRotateCounterClockWise.Click += new System.EventHandler(this.btnRotateCounterClockWise_Click);
            // 
            // contextMenuPictureBox
            // 
            this.contextMenuPictureBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImageSaveLocal});
            this.contextMenuPictureBox.Name = "contextMenuPictureBox";
            this.contextMenuPictureBox.Size = new System.Drawing.Size(266, 26);
            // 
            // MenuImageSaveLocal
            // 
            this.MenuImageSaveLocal.Name = "MenuImageSaveLocal";
            this.MenuImageSaveLocal.Size = new System.Drawing.Size(265, 22);
            this.MenuImageSaveLocal.Text = "Сохранить изображение локально";
            this.MenuImageSaveLocal.Click += new System.EventHandler(this.MenuImageSaveLocal_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddNewImage);
            this.splitContainer1.Panel2.Controls.Add(this.btnRefreshList);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxImages);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 491);
            this.splitContainer1.SplitterDistance = 730;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.ContextMenuStrip = this.contextMenuPictureBox;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::PictureViewer.Properties.Resources.NoImage;
            this.pictureBox.InitialImage = global::PictureViewer.Properties.Resources.DefaultImage;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(730, 491);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // btnAddNewImage
            // 
            this.btnAddNewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewImage.BackgroundImage = global::PictureViewer.Properties.Resources.plus;
            this.btnAddNewImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewImage.Location = new System.Drawing.Point(245, 0);
            this.btnAddNewImage.Name = "btnAddNewImage";
            this.btnAddNewImage.Size = new System.Drawing.Size(35, 35);
            this.btnAddNewImage.TabIndex = 88;
            this.btnAddNewImage.TabStop = false;
            this.btnAddNewImage.UseVisualStyleBackColor = true;
            this.btnAddNewImage.Click += new System.EventHandler(this.btnAddNewImage_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.BackgroundImage = global::PictureViewer.Properties.Resources.arrow;
            this.btnRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshList.Location = new System.Drawing.Point(279, 0);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(35, 35);
            this.btnRefreshList.TabIndex = 87;
            this.btnRefreshList.TabStop = false;
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список изображений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxImages
            // 
            this.listBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxImages.ContextMenuStrip = this.contextMenuListBox;
            this.listBoxImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 24;
            this.listBoxImages.Location = new System.Drawing.Point(0, 35);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(313, 460);
            this.listBoxImages.Sorted = true;
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.TabStop = false;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            this.listBoxImages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxImages_MouseDown);
            // 
            // contextMenuListBox
            // 
            this.contextMenuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuListBox.Name = "contextMenuPictureBox";
            this.contextMenuListBox.Size = new System.Drawing.Size(175, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "Удалить с сервера";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1049, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
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
            this.contextMenuPictureBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRotateCounterClockWise;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomOnOff;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnFlipVertically;
        private System.Windows.Forms.Button btnFlipHorizontally;
        private System.Windows.Forms.Button btnRotateClockWise;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuPictureBox;
        private System.Windows.Forms.ToolStripMenuItem MenuImageSaveLocal;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnAddNewImage;
        private System.Windows.Forms.ToolStripMenuItem btnSaveImageChange;
        private System.Windows.Forms.ContextMenuStrip contextMenuListBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}