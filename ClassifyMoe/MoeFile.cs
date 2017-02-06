using System;

namespace ClassifyMoe
{
  class MoeFile
  {
    public string characters;
    public string series;
    public string tags;
    public string filename;
    public DateTime dateModified;

    public MoeFile ()
    {

    }

    public MoeFile(string _characters, string _series, string _tags, string _filename, DateTime _dateModified)
    {
      characters = _characters;
      series = _series;
      tags = _tags;
      filename = _filename;
      dateModified = _dateModified;
    }
  }
}
