using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritingPadV2.Data;

namespace WritingPadV2.Services
{
    public class NotepadItemService : INotepadItemServis
    {
        private readonly NotepadDbContext _context;
        public NotepadItemService(NotepadDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NotepadItem>> GetIncompleteItemsAsync()
        {
            var items = await _context.NotepadItems.Where(s => s.IsActive == true).ToArrayAsync();

            return items;
        }
    }
}
