using System;
using System.Windows.Forms;

namespace ClassifyMoe
{
  public partial class MainForm : Form
  {
    public MainForm ()
    {
      InitializeComponent ();
      this.pathLabel.Text = "";
      saveButton.Enabled = false;
    }

    private void folderSelectButton_Click (object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog () == DialogResult.OK)
      {
        this.pathLabel.Text = folderBrowserDialog1.SelectedPath;
        resultTable.Controls.Clear ();
        new ScanFolder (folderBrowserDialog1.SelectedPath, resultTable);

        if (pathLabel.Text.Length > 0)
        {
          saveButton.Enabled = true;
        }
      }
    }

    private void saveButton_Click (object sender, EventArgs e)
    {
      new Save (pathLabel.Text, resultTable);
    }
  }
}
