using Microsoft.EntityFrameworkCore;
using NotelyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyProject.Database
{
    public class NotelyDBContext : DbContext
    {
        public NotelyDBContext(DbContextOptions<NotelyDBContext> options) : base(options) { }
        public DbSet<Note> Notes { get; set; }
    }
}
