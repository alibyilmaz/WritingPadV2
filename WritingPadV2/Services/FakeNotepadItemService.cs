using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WritingPadV2.Data;

namespace WritingPadV2.Services
{
    public class FakeNotepadItemService : INotepadItemServis
    {
        public Task<IEnumerable<NotepadItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<NotepadItem> items = new[]
            {
                new NotepadItem
                {
                    DueAt =DateTime.Now.AddDays(-1),
                    Explanation="Açıklama",
                    Title="Test",
                    IsActive=true,

                }
            };
            return Task.FromResult(items);
        }
    }
}
