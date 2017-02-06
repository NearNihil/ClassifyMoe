using System;
using System.Windows.Forms;

namespace ClassifyMoe
{
  internal class PopulateDataGridView
  {
    private MoeFile[] moeFiles;

    PopulateDataGridView(MoeFile[] _moeFiles)
    {
      moeFiles = _moeFiles;
    }

    public PopulateDataGridView (MoeFile[] moeFiles, DataGridView result)
    {
      if (moeFiles != null && moeFiles.Length > 0)
      {
        for (int i = 0; i < moeFiles.Length; i++)
        {
          if (result.RowCount <= i + 1)
          {
            result.Rows.Add (1);
          }
          DataGridViewRow row = (DataGridViewRow) result.Rows[i];

          row.Cells[0].Value = moeFiles[i].characters;
          row.Cells[1].Value = moeFiles[i].series;
          row.Cells[2].Value = moeFiles[i].tags;
          row.Cells[3].Value = moeFiles[i].filename;
          row.Cells[4].Value = moeFiles[i].dateModified;
        }
      }
    }
  }
}