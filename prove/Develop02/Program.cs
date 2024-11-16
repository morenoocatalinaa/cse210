using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public class Entry
    {
        public string Title { get; }
        public string Date { get; }
        public string Content { get; }

        public Entry(string title, string date, string content) =>
            (Title, Date, Content) = (title, date, content);

        public void Display() =>
            Console.WriteLine($"Title: {Title}\nDate: {Date}\nContent: {Content}\n");
    }

    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry) => _entries.Add(entry);
        public void DisplayAllEntries() => _entries.ForEach(entry => entry.Display());

        public void LoadEntriesFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i += 3)
                    _entries.Add(new Entry(lines[i], lines[i + 1], lines[i + 2]));
            }
            else
                Console.WriteLine("No saved journal found.");
        }

        public void SaveEntriesToFile(string fileName)
        {
            using var writer = new StreamWriter(fileName);
            _entries.ForEach(entry => writer.WriteLine($"{entry.Title}\n{entry.Date}\n{entry.Content}\n"));
        }
    }

    static void Main()
    {
        var myJournal = new Journal();
        const string fileName = "journal.txt";
        myJournal.LoadEntriesFromFile(fileName);

        while (true)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Title: ");
                    var title = Console.ReadLine();
                    Console.Write("Date (YYYY-MM-DD): ");
                    var date = Console.ReadLine();
                    Console.Write("Content: ");
                    var content = Console.ReadLine();
                    myJournal.AddEntry(new Entry(title, date, content));
                    break;
                case "2":
                    Console.WriteLine("\nMy Journal Entries:");
                    myJournal.DisplayAllEntries();
                    break;
                case "3":
                    myJournal.LoadEntriesFromFile(fileName);
                    break;
                case "4":
                    myJournal.SaveEntriesToFile(fileName);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
