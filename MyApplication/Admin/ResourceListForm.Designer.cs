namespace MyApplication.Admin
{
	partial class ResourceListForm
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
			this.searchPanel = new System.Windows.Forms.Panel();
			this.displayButton = new Dtx.Windows.Forms.Button();
			this.searchButton = new Dtx.Windows.Forms.Button();
			this.translatorLabel = new Dtx.Windows.Forms.Label();
			this.authorLabel = new Dtx.Windows.Forms.Label();
			this.translatorTextBox = new Dtx.Windows.Forms.TextBox();
			this.authorTextBox = new Dtx.Windows.Forms.TextBox();
			this.titleTextBox = new Dtx.Windows.Forms.TextBox();
			this.titleLabel = new Dtx.Windows.Forms.Label();
			this.gridPanel = new System.Windows.Forms.Panel();
			this.myDataGridView = new Dtx.Windows.Forms.DataGridView();
			this.searchPanel.SuspendLayout();
			this.gridPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.displayButton);
			this.searchPanel.Controls.Add(this.searchButton);
			this.searchPanel.Controls.Add(this.translatorLabel);
			this.searchPanel.Controls.Add(this.authorLabel);
			this.searchPanel.Controls.Add(this.translatorTextBox);
			this.searchPanel.Controls.Add(this.authorTextBox);
			this.searchPanel.Controls.Add(this.titleTextBox);
			this.searchPanel.Controls.Add(this.titleLabel);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.Margin = new System.Windows.Forms.Padding(2);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(441, 121);
			this.searchPanel.TabIndex = 0;
			// 
			// displayButton
			// 
			this.displayButton.Location = new System.Drawing.Point(160, 87);
			this.displayButton.Name = "displayButton";
			this.displayButton.Size = new System.Drawing.Size(75, 23);
			this.displayButton.TabIndex = 7;
			this.displayButton.Text = "&Display";
			this.displayButton.UseVisualStyleBackColor = false;
			this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(79, 87);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 6;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// translatorLabel
			// 
			this.translatorLabel.AutoSize = true;
			this.translatorLabel.Location = new System.Drawing.Point(11, 64);
			this.translatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.translatorLabel.Name = "translatorLabel";
			this.translatorLabel.Size = new System.Drawing.Size(64, 13);
			this.translatorLabel.TabIndex = 5;
			this.translatorLabel.Text = "&Translator";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(8, 39);
			this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(45, 13);
			this.authorLabel.TabIndex = 4;
			this.authorLabel.Text = "&Author";
			// 
			// translatorTextBox
			// 
			this.translatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.translatorTextBox.Location = new System.Drawing.Point(79, 61);
			this.translatorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.translatorTextBox.Name = "translatorTextBox";
			this.translatorTextBox.Size = new System.Drawing.Size(351, 21);
			this.translatorTextBox.TabIndex = 3;
			// 
			// authorTextBox
			// 
			this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.authorTextBox.Location = new System.Drawing.Point(79, 36);
			this.authorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(351, 21);
			this.authorTextBox.TabIndex = 2;
			// 
			// titleTextBox
			// 
			this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextBox.Location = new System.Drawing.Point(79, 11);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(351, 21);
			this.titleTextBox.TabIndex = 1;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(8, 14);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(31, 13);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "&Title";
			// 
			// gridPanel
			// 
			this.gridPanel.Controls.Add(this.myDataGridView);
			this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPanel.Location = new System.Drawing.Point(0, 121);
			this.gridPanel.Margin = new System.Windows.Forms.Padding(2);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(441, 194);
			this.gridPanel.TabIndex = 1;
			// 
			// myDataGridView
			// 
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myDataGridView.Location = new System.Drawing.Point(0, 0);
			this.myDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.RowHeadersWidth = 62;
			this.myDataGridView.RowTemplate.Height = 28;
			this.myDataGridView.Size = new System.Drawing.Size(441, 194);
			this.myDataGridView.TabIndex = 0;
			// 
			// ResourceListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 315);
			this.Controls.Add(this.gridPanel);
			this.Controls.Add(this.searchPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ResourceListForm";
			this.Text = "Resource List";
			this.Load += new System.EventHandler(this.ResourceListForm_Load);
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.gridPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.Panel gridPanel;
		private Dtx.Windows.Forms.DataGridView myDataGridView;
		private Dtx.Windows.Forms.Label translatorLabel;
		private Dtx.Windows.Forms.Label authorLabel;
		private Dtx.Windows.Forms.TextBox translatorTextBox;
		private Dtx.Windows.Forms.TextBox authorTextBox;
		private Dtx.Windows.Forms.TextBox titleTextBox;
		private Dtx.Windows.Forms.Label titleLabel;
		private Dtx.Windows.Forms.Button searchButton;
		private Dtx.Windows.Forms.Button displayButton;
	}
}