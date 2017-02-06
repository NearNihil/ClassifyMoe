namespace ClassifyMoe
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
      this.folderSelectLabel = new System.Windows.Forms.Label();
      this.subfolderCheckboxLabel = new System.Windows.Forms.Label();
      this.folderSelectButton = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.pathLabel = new System.Windows.Forms.Label();
      this.scanSubfoldersCheckbox = new System.Windows.Forms.CheckBox();
      this.resultTable = new System.Windows.Forms.DataGridView();
      this.Characters = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saveButton = new System.Windows.Forms.Button();
      this.loadButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
      this.SuspendLayout();
      // 
      // folderSelectLabel
      // 
      this.folderSelectLabel.AutoSize = true;
      this.folderSelectLabel.Location = new System.Drawing.Point(16, 13);
      this.folderSelectLabel.Name = "folderSelectLabel";
      this.folderSelectLabel.Size = new System.Drawing.Size(29, 13);
      this.folderSelectLabel.TabIndex = 0;
      this.folderSelectLabel.Text = "Path";
      // 
      // subfolderCheckboxLabel
      // 
      this.subfolderCheckboxLabel.AutoSize = true;
      this.subfolderCheckboxLabel.Location = new System.Drawing.Point(16, 50);
      this.subfolderCheckboxLabel.Name = "subfolderCheckboxLabel";
      this.subfolderCheckboxLabel.Size = new System.Drawing.Size(83, 13);
      this.subfolderCheckboxLabel.TabIndex = 1;
      this.subfolderCheckboxLabel.Text = "Scan subfolders";
      // 
      // folderSelectButton
      // 
      this.folderSelectButton.Location = new System.Drawing.Point(119, 8);
      this.folderSelectButton.Name = "folderSelectButton";
      this.folderSelectButton.Size = new System.Drawing.Size(75, 23);
      this.folderSelectButton.TabIndex = 2;
      this.folderSelectButton.Text = "Browse...";
      this.folderSelectButton.UseVisualStyleBackColor = true;
      this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
      // 
      // pathLabel
      // 
      this.pathLabel.Location = new System.Drawing.Point(217, 13);
      this.pathLabel.Name = "pathLabel";
      this.pathLabel.Size = new System.Drawing.Size(295, 23);
      this.pathLabel.TabIndex = 3;
      this.pathLabel.Text = "pathLabel";
      // 
      // scanSubfoldersCheckbox
      // 
      this.scanSubfoldersCheckbox.AutoSize = true;
      this.scanSubfoldersCheckbox.Location = new System.Drawing.Point(119, 50);
      this.scanSubfoldersCheckbox.Name = "scanSubfoldersCheckbox";
      this.scanSubfoldersCheckbox.Size = new System.Drawing.Size(15, 14);
      this.scanSubfoldersCheckbox.TabIndex = 4;
      this.scanSubfoldersCheckbox.UseVisualStyleBackColor = true;
      // 
      // resultTable
      // 
      this.resultTable.AllowUserToAddRows = false;
      this.resultTable.AllowUserToDeleteRows = false;
      this.resultTable.AllowUserToResizeColumns = false;
      this.resultTable.AllowUserToResizeRows = false;
      this.resultTable.CausesValidation = false;
      this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Characters,
            this.Series,
            this.Tags,
            this.Filename});
      this.resultTable.Location = new System.Drawing.Point(19, 81);
      this.resultTable.Name = "resultTable";
      this.resultTable.ReadOnly = true;
      this.resultTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.resultTable.Size = new System.Drawing.Size(726, 417);
      this.resultTable.TabIndex = 5;
      // 
      // Characters
      // 
      this.Characters.HeaderText = "Characters";
      this.Characters.Name = "Characters";
      this.Characters.ReadOnly = true;
      this.Characters.Width = 150;
      // 
      // Series
      // 
      this.Series.HeaderText = "Series";
      this.Series.Name = "Series";
      this.Series.ReadOnly = true;
      this.Series.Width = 150;
      // 
      // Tags
      // 
      this.Tags.HeaderText = "Tags";
      this.Tags.Name = "Tags";
      this.Tags.ReadOnly = true;
      this.Tags.Width = 150;
      // 
      // Filename
      // 
      this.Filename.HeaderText = "Filename";
      this.Filename.Name = "Filename";
      this.Filename.ReadOnly = true;
      this.Filename.Width = 150;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(670, 504);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(75, 23);
      this.saveButton.TabIndex = 6;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // loadButton
      // 
      this.loadButton.Location = new System.Drawing.Point(589, 504);
      this.loadButton.Name = "loadButton";
      this.loadButton.Size = new System.Drawing.Size(75, 23);
      this.loadButton.TabIndex = 7;
      this.loadButton.Text = "Load";
      this.loadButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(757, 539);
      this.Controls.Add(this.loadButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.resultTable);
      this.Controls.Add(this.scanSubfoldersCheckbox);
      this.Controls.Add(this.pathLabel);
      this.Controls.Add(this.folderSelectButton);
      this.Controls.Add(this.subfolderCheckboxLabel);
      this.Controls.Add(this.folderSelectLabel);
      this.Name = "MainForm";
      this.Text = "Classify Moe";
      ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label folderSelectLabel;
    private System.Windows.Forms.Label subfolderCheckboxLabel;
    private System.Windows.Forms.Button folderSelectButton;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Label pathLabel;
    private System.Windows.Forms.CheckBox scanSubfoldersCheckbox;
    private System.Windows.Forms.DataGridView resultTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn Characters;
    private System.Windows.Forms.DataGridViewTextBoxColumn Series;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
    private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button loadButton;
  }
}

