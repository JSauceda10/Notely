using NotelyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyProject.Repositories
{
    public interface INoteRepository
    {
        public Note FindNoteById(long id);
        public IEnumerable<Note> GetAllNotes();
        public void SaveNote(Note note);
        public void EditNote(Note note);
        public void DeleteNote(Note note);
    }
}
