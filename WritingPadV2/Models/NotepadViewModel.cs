using System.Collections.Generic;
using WritingPadV2.Data;

namespace WritingPadV2.Models
{
    public class NotepadViewModel
    {
        public IEnumerable<NotepadItem> Items { get; set; }
    }
}
