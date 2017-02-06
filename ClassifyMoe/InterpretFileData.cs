using System;
using System.Windows.Forms;

namespace ClassifyMoe
{
  internal class InterpretFileData
  {
    private MoeFile[] moeFiles;

    public InterpretFileData (MoeFile[] moeFiles)
    {
      this.moeFiles = moeFiles;
    }

    public MoeFile[] Interpret (MoeFile[] moeFiles)
    {
      if (moeFiles != null && moeFiles.Length > 0)
      {
        for (int i = 0; i < moeFiles.Length; i++)
        {
          MoeFile moeFile = new MoeFile ();
          Console.WriteLine ("Processing " + moeFiles[i].fullPath + "...");

          if (moeFiles[i].fullPath.Contains ("-")) //file has at least a character OR a series OR a tag
          {
            if (moeFiles[i].fullPath.Contains ("(") && moeFiles[i].fullPath.Contains (")")) //file has at least a series
            {
              moeFiles[i].characters = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.LastIndexOf ("\\") + 1, moeFiles[i].fullPath.IndexOf ("(") - moeFiles[i].fullPath.LastIndexOf ("\\") - 1).Trim ();
              moeFiles[i].series = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.IndexOf ("(") + 1, moeFiles[i].fullPath.IndexOf (")") - moeFiles[i].fullPath.IndexOf ("(") - 1).Trim ();
              moeFiles[i].filename = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.LastIndexOf ("-") + 1).Trim ();
              moeFiles[i].tags = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.IndexOf (")") + 1, moeFiles[i].fullPath.LastIndexOf ("-") - moeFiles[i].fullPath.IndexOf (")") - 1).Trim ();
            }
            else //file does not have a series, but does have a tag or character. interpret as character.
            {
              moeFiles[i].characters = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.LastIndexOf ("\\") + 1, moeFiles[i].fullPath.LastIndexOf ("-") - moeFiles[i].fullPath.LastIndexOf ("\\") - 1).Trim ();
              moeFiles[i].filename = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.IndexOf ("-") + 1).Trim ();
            }
          }
          else
          {
            moeFiles[i].filename = moeFiles[i].fullPath.Substring (moeFiles[i].fullPath.LastIndexOf ("\\") + 1).Trim ();
          }
        }
      }
      return moeFiles;
    }
  }
}