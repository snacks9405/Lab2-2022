using System.Collections.Generic;

namespace Lab1_2021
{
    public interface IDatabase
    {
        void AddEntry(Entry entry);
        bool DeleteEntry(Entry entry);
        Entry FindEntry(int id);
        SortedDictionary<int, Entry> GetEntries();
        int GetNextAvailableID();
        bool ReplaceEntry(Entry replacementEntry);
    }
}