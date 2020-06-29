using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritingPadV2.Models;

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
                    DueAt =DateTimeOffset.Now.AddDays(1),
                    Explanation="Açıklama",
                    Title="Test",
                    IsActive=true,

                }
            };
            return Task.FromResult(items);
        }
    }
}
