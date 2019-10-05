namespace MyApplication.Admin
{
	partial class DisplayResourceForm
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
			this.descriptionLabel = new Dtx.Windows.Forms.Label();
			this.publishYearLabel = new Dtx.Windows.Forms.Label();
			this.translatorLabel = new Dtx.Windows.Forms.Label();
			this.authorLabel = new Dtx.Windows.Forms.Label();
			this.typeLabel = new Dtx.Windows.Forms.Label();
			this.titleLabel = new Dtx.Windows.Forms.Label();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.publishYearTextBox = new Dtx.Windows.Forms.TextBox();
			this.translatorTextBox = new Dtx.Windows.Forms.TextBox();
			this.authorTextBox = new Dtx.Windows.Forms.TextBox();
			this.typeComboBox = new Dtx.Windows.Forms.ComboBox();
			this.titleTextBox = new Dtx.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(8, 150);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
			this.descriptionLabel.TabIndex = 23;
			this.descriptionLabel.Text = "&Description";
			// 
			// publishYearLabel
			// 
			this.publishYearLabel.AutoSize = true;
			this.publishYearLabel.Location = new System.Drawing.Point(8, 123);
			this.publishYearLabel.Name = "publishYearLabel";
			this.publishYearLabel.Size = new System.Drawing.Size(76, 13);
			this.publishYearLabel.TabIndex = 21;
			this.publishYearLabel.Text = "&Publish Year";
			// 
			// translatorLabel
			// 
			this.translatorLabel.AutoSize = true;
			this.translatorLabel.Location = new System.Drawing.Point(8, 96);
			this.translatorLabel.Name = "translatorLabel";
			this.translatorLabel.Size = new System.Drawing.Size(64, 13);
			this.translatorLabel.TabIndex = 19;
			this.translatorLabel.Text = "&Translator";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(8, 69);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(45, 13);
			this.authorLabel.TabIndex = 17;
			this.authorLabel.Text = "&Author";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(8, 42);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(34, 13);
			this.typeLabel.TabIndex = 15;
			this.typeLabel.Text = "T&ype";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(8, 15);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(31, 13);
			this.titleLabel.TabIndex = 13;
			this.titleLabel.Text = "&Title";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(90, 147);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ReadOnly = true;
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(436, 146);
			this.descriptionTextBox.TabIndex = 24;
			// 
			// publishYearTextBox
			// 
			this.publishYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.publishYearTextBox.Location = new System.Drawing.Point(90, 120);
			this.publishYearTextBox.Name = "publishYearTextBox";
			this.publishYearTextBox.ReadOnly = true;
			this.publishYearTextBox.Size = new System.Drawing.Size(436, 21);
			this.publishYearTextBox.TabIndex = 22;
			// 
			// translatorTextBox
			// 
			this.translatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.translatorTextBox.Location = new System.Drawing.Point(90, 93);
			this.translatorTextBox.Name = "translatorTextBox";
			this.translatorTextBox.ReadOnly = true;
			this.translatorTextBox.Size = new System.Drawing.Size(436, 21);
			this.translatorTextBox.TabIndex = 20;
			// 
			// authorTextBox
			// 
			this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.authorTextBox.Location = new System.Drawing.Point(90, 66);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.ReadOnly = true;
			this.authorTextBox.Size = new System.Drawing.Size(436, 21);
			this.authorTextBox.TabIndex = 18;
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.Enabled = false;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(90, 39);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(436, 21);
			this.typeComboBox.TabIndex = 16;
			// 
			// titleTextBox
			// 
			this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextBox.Location = new System.Drawing.Point(90, 12);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.ReadOnly = true;
			this.titleTextBox.Size = new System.Drawing.Size(436, 21);
			this.titleTextBox.TabIndex = 14;
			// 
			// DisplayResourceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 305);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.publishYearLabel);
			this.Controls.Add(this.translatorLabel);
			this.Controls.Add(this.authorLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.publishYearTextBox);
			this.Controls.Add(this.translatorTextBox);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.titleTextBox);
			this.Name = "DisplayResourceForm";
			this.Text = "Display Resource";
			this.Load += new System.EventHandler(this.DisplayResourceForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Dtx.Windows.Forms.Label descriptionLabel;
		private Dtx.Windows.Forms.Label publishYearLabel;
		private Dtx.Windows.Forms.Label translatorLabel;
		private Dtx.Windows.Forms.Label authorLabel;
		private Dtx.Windows.Forms.Label typeLabel;
		private Dtx.Windows.Forms.Label titleLabel;
		private Dtx.Windows.Forms.TextBox descriptionTextBox;
		private Dtx.Windows.Forms.TextBox publishYearTextBox;
		private Dtx.Windows.Forms.TextBox translatorTextBox;
		private Dtx.Windows.Forms.TextBox authorTextBox;
		private Dtx.Windows.Forms.ComboBox typeComboBox;
		private Dtx.Windows.Forms.TextBox titleTextBox;
	}
}