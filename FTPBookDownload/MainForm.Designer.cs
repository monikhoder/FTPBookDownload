namespace FTPBookDownload
{
    partial class MainForm
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
            KimTools.WinForms.KtTableColumn ktTableColumn1 = new KimTools.WinForms.KtTableColumn();
            this.FrmTheme = new KimTools.WinForms.KtTheme(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.tblBook = new KimTools.WinForms.KtTable();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDownloadLoading = new System.Windows.Forms.Label();
            this.btnDownload = new KimTools.WinForms.KtButton();
            this.cover_panel = new System.Windows.Forms.Panel();
            this.lblLoadingCover = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TexbookLoading = new System.Windows.Forms.Label();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cover_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrmTheme
            // 
            this.FrmTheme.Accent = System.Drawing.Color.Empty;
            this.FrmTheme.Contrast = 10D;
            this.FrmTheme.Dark = false;
            this.FrmTheme.Primary = System.Drawing.Color.Empty;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.tblBook);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(187, 450);
            this.LeftPanel.TabIndex = 0;
            // 
            // tblBook
            // 
            this.tblBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            ktTableColumn1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            ktTableColumn1.Fill = "";
            ktTableColumn1.Format = "";
            ktTableColumn1.Group = "";
            ktTableColumn1.IsPrimaryKey = false;
            ktTableColumn1.Key = "tblname";
            ktTableColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.NotSet;
            ktTableColumn1.Search = true;
            ktTableColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ktTableColumn1.Template = "";
            ktTableColumn1.Title = "Book Title";
            ktTableColumn1.ToolTip = "";
            ktTableColumn1.Type = KimTools.WinForms.KtTableColumnTypes.Text;
            ktTableColumn1.Value = "";
            ktTableColumn1.Visible = true;
            ktTableColumn1.Width = 0;
            ktTableColumn1.Width_ = "";
            this.tblBook.Columns = new KimTools.WinForms.KtTableColumn[] {
        ktTableColumn1};
            this.tblBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBook.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblBook.KeyCaseSensitive = false;
            this.tblBook.Latency = 500;
            this.tblBook.Location = new System.Drawing.Point(0, 0);
            this.tblBook.MultiSelect = false;
            this.tblBook.Name = "tblBook";
            this.tblBook.Padding = new System.Windows.Forms.Padding(5);
            this.tblBook.ShowFooter = false;
            this.tblBook.ShowHeader = true;
            this.tblBook.ShowSearch = true;
            this.tblBook.Size = new System.Drawing.Size(187, 450);
            this.tblBook.TabIndex = 0;
            this.tblBook.CellClick += new KimTools.WinForms.KtTable.KtTableRowCellEventArgs(this.tblBook_CellClick);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.cover_panel);
            this.TopPanel.Controls.Add(this.lblTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(187, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(613, 133);
            this.TopPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDownloadLoading);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(423, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 133);
            this.panel1.TabIndex = 5;
            // 
            // lblDownloadLoading
            // 
            this.lblDownloadLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloadLoading.AutoSize = true;
            this.lblDownloadLoading.Location = new System.Drawing.Point(29, 77);
            this.lblDownloadLoading.Name = "lblDownloadLoading";
            this.lblDownloadLoading.Size = new System.Drawing.Size(136, 25);
            this.lblDownloadLoading.TabIndex = 4;
            this.lblDownloadLoading.Text = "Downloading...";
            this.lblDownloadLoading.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Empty;
            this.btnDownload.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnDownload.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnDownload.CustomColors = new System.Drawing.Color[0];
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDownload.IconName = "Tabler.outline.download";
            this.btnDownload.IconSize = 16;
            this.btnDownload.IconStroke = 2.5D;
            this.btnDownload.Location = new System.Drawing.Point(34, 23);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(126, 44);
            this.btnDownload.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cover_panel
            // 
            this.cover_panel.Controls.Add(this.lblLoadingCover);
            this.cover_panel.Controls.Add(this.BookCover);
            this.cover_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cover_panel.Location = new System.Drawing.Point(0, 0);
            this.cover_panel.Name = "cover_panel";
            this.cover_panel.Size = new System.Drawing.Size(123, 133);
            this.cover_panel.TabIndex = 3;
            // 
            // lblLoadingCover
            // 
            this.lblLoadingCover.AutoSize = true;
            this.lblLoadingCover.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingCover.Location = new System.Drawing.Point(30, 42);
            this.lblLoadingCover.Name = "lblLoadingCover";
            this.lblLoadingCover.Size = new System.Drawing.Size(91, 25);
            this.lblLoadingCover.TabIndex = 1;
            this.lblLoadingCover.Text = "Loading...";
            // 
            // BookCover
            // 
            this.BookCover.Location = new System.Drawing.Point(21, 9);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(86, 93);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover.TabIndex = 0;
            this.BookCover.TabStop = false;
            this.BookCover.WaitOnLoad = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(154, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Title";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.TexbookLoading);
            this.MainPanel.Controls.Add(this.bookTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(187, 133);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(613, 317);
            this.MainPanel.TabIndex = 2;
            // 
            // TexbookLoading
            // 
            this.TexbookLoading.AutoSize = true;
            this.TexbookLoading.BackColor = System.Drawing.Color.Transparent;
            this.TexbookLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexbookLoading.Location = new System.Drawing.Point(0, 0);
            this.TexbookLoading.Name = "TexbookLoading";
            this.TexbookLoading.Size = new System.Drawing.Size(91, 25);
            this.TexbookLoading.TabIndex = 2;
            this.TexbookLoading.Text = "Loading...";
            // 
            // bookTextBox
            // 
            this.bookTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookTextBox.Location = new System.Drawing.Point(0, 0);
            this.bookTextBox.Multiline = true;
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.ReadOnly = true;
            this.bookTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookTextBox.Size = new System.Drawing.Size(613, 317);
            this.bookTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.Name = "MainForm";
            this.Opacity = 1D;
            this.Text = "FTP BOOK DOWNLOAD";
            this.Theme = this.FrmTheme;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cover_panel.ResumeLayout(false);
            this.cover_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KimTools.WinForms.KtTheme FrmTheme;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private KimTools.WinForms.KtTable tblBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox BookCover;
        private KimTools.WinForms.KtButton btnDownload;
        private System.Windows.Forms.Panel cover_panel;
        private System.Windows.Forms.Label lblLoadingCover;
        private System.Windows.Forms.Label TexbookLoading;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.Label lblDownloadLoading;
        private System.Windows.Forms.Panel panel1;
    }
}

