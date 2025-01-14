using System.IO;
public class Journal{

    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }

    public void DisplayAll(){
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string fileName){
        using (StreamWriter outPutFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outPutFile.WriteLine($"{e.GetDate()}|{e.GetPrompt()}'|{e.GetResponse()}");
            }
        }
    }

    public void LoadFromFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Entry entry;
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            entry = new Entry();
            entry.SetDate(DateTime.Parse(parts[0]));
            entry.SetPrompt(parts[1]);
            entry.SetResponse(parts[2]);
            _entries.Add(entry);
        }
    }
}