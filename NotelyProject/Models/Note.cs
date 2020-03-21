using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyProject.Models
{
    public class Note
    {
        public long id { get; set; }
        public String subject { get; set; }
        public String detail { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastModified { get; set; }
        public bool isDeleted { get; set; }

    }
}
