using System;
using System.Diagnostics;
using static System.Console;
//A single class should have one responsibilty and should be one reason to change
public class Journal
{
    private readonly List<string> entries = new List<string>();
    private static int count = 0;
    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count; //memento
    }
    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }
    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
    ///
    /// Following methods of Save and Load add more responsibility to journal class
    /// that should be the part of other class so Journal class has one responibility to
    /// keep handling journal in memory not persistance handling
    /// 
    /*
    public void Save(string fileName)
    {
        File.WriteAllText(fileName,ToString());
    }
    public static Journal Load(string fileName)
    {
        
    }
    public void Load(Uri uri)
    {}
    */
}
public class Persistance
{
    public void SaveToFile(Journal j, string fileName, bool overwrite = false)
    {
        if(overwrite || !File.Exists(fileName))
        File.WriteAllText(fileName,j.ToString());
    }

}
class SRP
{
    static void Main()
    {
        var j = new Journal();
        j.AddEntry("I cried today");
        j.AddEntry("I age a bug");
        WriteLine(j);
        
        var p = new Persistance();
        var fileName = @"c:\temp\journal.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(fileName)!);
        p.SaveToFile(j, fileName, true);
        Process.Start(new ProcessStartInfo(fileName)
        {
            UseShellExecute = true
        });        
    }
}