using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotelyProject.Models;
using NotelyProject.Repositories;

namespace NotelyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteRepository _noteRepository;

        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(long id)
        {
            var note = _noteRepository.FindNoteById(id);

            return note;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetNotes()
        {
            var notes = _noteRepository.GetAllNotes().ToList();
            return notes;
        }
        [HttpPost]
        public ActionResult<Note> PostNote(Note note)
        {
            var currentDate = DateTime.Now;
            note.createdDate = currentDate;
            note.lastModified = currentDate;
            _noteRepository.SaveNote(note);
            return note;
        }
        [HttpPut]
        public ActionResult<Note> PutNote(Note note)
        {
            note.lastModified = DateTime.Now;
            _noteRepository.EditNote(note);
            return note;
        }
        [HttpDelete("{id}")]
        public ActionResult<Note> DeleteNote(long id)
        {
            var note = _noteRepository.FindNoteById(id);
            _noteRepository.DeleteNote(note);
            return note;
        }
    }
}