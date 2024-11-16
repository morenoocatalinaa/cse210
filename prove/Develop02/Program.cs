using System;
using System.Collections.Generic;

class Program
{

    public class Entry
    {
        private string _title;
        private string _date;
        private string _content;

        public Entry(string title, string date, string content)
        {
            _title = title;
            _date = date;
            _content = content;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Content: {_content}");
        }
    }


    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAllEntries()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine(); 
            }
        }
    }

    static void Main(string[] args)
    {

        Journal myJournal = new Journal();


        Entry entry1 = new Entry("Daily Thoughts", "2024-11-16", "Today was a productive day! I learned about abstraction in programming.");
        Entry entry2 = new Entry("Weekend Plans", "2024-11-17", "Looking forward to a relaxing weekend with family and friends.");


        myJournal.AddEntry(entry1);
        myJournal.AddEntry(entry2);


        Console.WriteLine("My Journal Entries:");
        myJournal.DisplayAllEntries();
    }
}
