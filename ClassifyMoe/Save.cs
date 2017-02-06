using System;
using System.IO;
using System.Windows.Forms;

namespace ClassifyMoe
{
  class Save
  {
    public Save (string path, DataGridView input)
    {
      //string[] fileDataToWrite = new string[10];
      string[] fileDataToWrite = new string[input.RowCount];

      for (int i = 0; i < input.RowCount; i++)
      {
        if (input.Rows[i].Cells[0].Value != null) //characters
        {
          fileDataToWrite[i] = input.Rows[i].Cells[0].Value.ToString ();
        }

        if (input.Rows[i].Cells[1].Value != null && input.Rows[i].Cells[1].Value.ToString ().Length != 0) //series
        {
          if (fileDataToWrite[i] != null && fileDataToWrite[i].Length != 0)
          {
            fileDataToWrite[i] += " ";
          }

          fileDataToWrite[i] += "(" + input.Rows[i].Cells[1].Value.ToString () + ")";
        }

        if (input.Rows[i].Cells[2].Value != null && input.Rows[i].Cells[2].Value.ToString().Length != 0) //tags
        {
          if (fileDataToWrite[i] != null && fileDataToWrite[i].Length != 0)
          {
            fileDataToWrite[i] += " ";
          }

          fileDataToWrite[i] += input.Rows[i].Cells[2].Value.ToString ();
        }

        if (input.Rows[i].Cells[3].Value != null && input.Rows[i].Cells[3].Value.ToString ().Length != 0) //filename
        {
          if (fileDataToWrite[i] != null && fileDataToWrite[i].Length != 0)
          {
            fileDataToWrite[i] += " - " + input.Rows[i].Cells[3].Value.ToString ();
          }
          else
          {
            fileDataToWrite[i] = input.Rows[i].Cells[3].Value.ToString ();
          }
        }

        Console.WriteLine (fileDataToWrite[i]);
      }

      Console.WriteLine ("Data to write: \n" + fileDataToWrite[0]);
      Console.WriteLine ("Input: \n" + input.Rows[5].Cells[0].Value.ToString ());

      File.WriteAllLines (path + "\\ClassifyMoe.poi", fileDataToWrite);
    }

  }
}
