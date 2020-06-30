using Microsoft.EntityFrameworkCore;

namespace WritingPadV2.Data
{
    public class NotepadDbContext: DbContext
    {
        public NotepadDbContext(DbContextOptions<NotepadDbContext> options) : base(options) { }

        public DbSet<NotepadItem> NotepadItems { get; set; }
    }
}

