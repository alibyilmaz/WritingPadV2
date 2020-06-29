using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WritingPadV2.Models
{
    public class NotepadItem
    {
        public int NotePadId { get; set; }

        public string Title { get; set; }

        public string Explanation { get; set; }

        public int AppUserId { get; set; }

        public string NoteUrl { get; set; }

        public string FilePath { get; set; }

        public bool IsActive { get; set; }

        public DateTime? DueAt { get; set; }
    }
}
