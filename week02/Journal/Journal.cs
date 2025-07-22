    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("Your journal is empty. Write some entries first!");
                return;
            }

            Console.WriteLine("\n--- Journal Entries ---");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
            Console.WriteLine("--- End of Journal ---");
        }

        public void SaveToFile(string file)
        {
            Console.WriteLine($"Saving to file: {file}");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile(string file)
        {
            Console.WriteLine($"Loading from file: {file}");
            _entries.Clear();

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found. Please check the filename.");
                return;
            }

            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
                else
                {
                    Console.WriteLine($"Skipping malformed line: {line}");
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }

        // New Method for creativity: Get the total number of entries
        public int GetEntryCount()
        {
            return _entries.Count;
        }
    }