using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ClassifyMoe
{
  class ScanFolder
  {
    public MoeFile[] GetMoeFiles (string path)
    {
      MoeFile[] moeFiles = new MoeFile[Directory.GetFiles (path).Length];
      FileInfo[] allFiles = Directory.GetFiles (path).Select (fn => new FileInfo (fn)).OrderByDescending (f => f.LastWriteTimeUtc).ToArray();

      if (allFiles != null && allFiles.Length > 0)
      {
        for (int i = 0; i < allFiles.Length; i++)
        {
          MoeFile moeFile = new MoeFile ();
          moeFile.fullPath = allFiles[i].FullName;
          moeFile.dateModified = allFiles[i].LastWriteTimeUtc;
          moeFiles[i] = moeFile;
        }
      }

      return moeFiles;
    }
  }
}
