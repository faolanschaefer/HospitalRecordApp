using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Office
    {
        private List<Note> notes;
        private int nextId;

        public Office()
        {
            notes = new List<Note>();
            nextId = 0;
        }
        public void AddNote(Note note)
        {
            notes.Add(note);
            nextId++;
        }
        public int NextId { get => nextId; }
        public List<Note> Notes { get => notes; }

        public void UpdateNote(Note newNote)
        {
            DeleteNote(newNote);
            notes.Add(newNote);
        }
        public void DeleteNote(Note oldNote)
        {
            notes.Remove(notes.Find(note => note.NoteId == oldNote.NoteId));

        }
        public void SaveNotes()
        {
            string path = Path.GetFullPath(@"../../PatientNotes.txt");
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Note note in notes)
                {
                    writer.WriteLine(note.ToString());
                }
            }
        }
        public void LoadNotes()
        {
            string path = Path.GetFullPath(@"../../PatientNotes.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadLine();
                    while (!string.IsNullOrEmpty(line))
                    {
                        notes.Add(new Note(line));
                        line = reader.ReadLine();
                    }
                }

                foreach(Note note in notes)
                {
                    if (note.NoteId >= nextId)
                    {
                        nextId = note.NoteId + 1;
                    }
                }
            }
        }
    }
}
