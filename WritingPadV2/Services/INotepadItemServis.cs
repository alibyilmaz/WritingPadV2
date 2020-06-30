using System.Collections.Generic;
using System.Threading.Tasks;
using WritingPadV2.Data;

namespace WritingPadV2.Services
{
    public interface INotepadItemServis
    {
        Task<IEnumerable<NotepadItem>> GetIncompleteItemsAsync();
    }
}
