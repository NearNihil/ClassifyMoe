using System;

namespace ClassifyMoe
{
  class MoeFile
  {
    public string fullPath;
    public string characters;
    public string series;
    public string tags;
    public string filename;
    public DateTime dateModified;

    public MoeFile ()
    {

    }

    public MoeFile(string _fullPath, DateTime _dateModified, string _characters, string _series, string _tags, string _filename)
    {
      fullPath = _fullPath;
      dateModified = _dateModified;
      characters = _characters;
      series = _series;
      tags = _tags;
      filename = _filename;
    }
  }
}
