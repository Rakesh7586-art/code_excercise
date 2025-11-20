using System.IO;

namespace BigCommpanyAnalyzer.Utils;

public static class CsvReaders
{
  public static IEnumerable<string> ReadLins(string filepath)
  {  
    return File.ReadAllLines(filePath)
      .Where(line => !string.IsNullorWhiteSpace(line)).Skip(1);
  }
}
