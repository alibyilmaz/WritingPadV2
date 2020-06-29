using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WritingPadV2.Models
{
    public class NotepadViewModel
    {
        public IEnumerable<NotepadItem> Items { get; set; }
    }
}
