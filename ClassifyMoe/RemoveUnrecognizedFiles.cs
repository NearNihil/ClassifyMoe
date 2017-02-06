using System;
using System.Linq;
using System.Windows.Forms;

namespace ClassifyMoe
{
  class RemoveUnrecognizedFiles
  {
    public RemoveUnrecognizedFiles(DataGridView input)
    {
      string[] recognizedFileTypes = { ".png", ".jpg", ".jpeg", ".gif", ".webm", ".mp4" };

      for (int i = 0; i < input.Rows.Count; i++)
      {
        string fileType = input.Rows[i].Cells[3].Value.ToString().Substring(input.Rows[i].Cells[3].Value.ToString().LastIndexOf("."));
        if (!recognizedFileTypes.Contains (fileType))
        {
          Console.WriteLine ("Removing " + input.Rows[i].Cells[3].Value + "...");
          input.Rows.RemoveAt(i);
        }
      }
    }
  }
}
