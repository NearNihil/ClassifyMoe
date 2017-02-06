using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ClassifyMoe
{
  class ScanFolder
  {
    public ScanFolder (string path, DataGridView result)
    {
      //string[] files = Directory.GetFiles (path);
      string[] files;

      var sortedFiles = Directory.GetFiles (path).Select(fn => new FileInfo(fn)).OrderBy (f => f.Length);

      if (files != null && files.Length > 0)
      {
        for (int i = 0; i < files.Length; i++)
        {
          MoeFile moeFile = new MoeFile ();
          Console.WriteLine ("Processing " + files[i] + "...");

          if (files[i].Contains ("-")) //file has at least a character OR a series OR a tag
          {
            if (files[i].Contains ("(") && files[i].Contains (")")) //file has at least a series
            {
              moeFile.characters = files[i].Substring (files[i].LastIndexOf ("\\") + 1, files[i].IndexOf ("(") - files[i].LastIndexOf ("\\") - 1).Trim ();
              moeFile.series = files[i].Substring (files[i].IndexOf ("(") + 1, files[i].IndexOf (")") - files[i].IndexOf ("(") - 1).Trim ();
              moeFile.filename = files[i].Substring (files[i].LastIndexOf ("-") + 1).Trim ();
              moeFile.tags = files[i].Substring (files[i].IndexOf (")") + 1, files[i].LastIndexOf ("-") - files[i].IndexOf (")") - 1).Trim ();
            }
            else //file does not have a series, but does have a tag or character. interpret as character.
            {
              moeFile.characters = files[i].Substring (files[i].LastIndexOf ("\\") + 1, files[i].LastIndexOf ("-") - files[i].LastIndexOf ("\\") - 1).Trim ();
              moeFile.filename = files[i].Substring (files[i].IndexOf ("-") + 1).Trim ();
            }
          }
          else
          {
            moeFile.filename = files[i].Substring (files[i].LastIndexOf ("\\") + 1).Trim ();
          }

          if (result.RowCount <= i + 1)
          {
            result.Rows.Add(1);
          }

          DataGridViewRow row = (DataGridViewRow) result.Rows[i];

          row.Cells[0].Value = moeFile.characters;
          row.Cells[1].Value = moeFile.series;
          row.Cells[2].Value = moeFile.tags;
          row.Cells[3].Value = moeFile.filename;
        }

        new RemoveUnrecognizedFiles (result);
      }
    }
  }
}
