using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritingPadV2.Models;

namespace WritingPadV2.Services
{
    public interface INotepadItemServis
    {
        Task<IEnumerable<NotepadItem>> GetIncompleteItemsAsync();
    }
}
