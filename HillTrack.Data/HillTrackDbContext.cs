using HillTrack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HillTrack.Data
{
    public class HillTrackDbContext : DbContext
    {
        public HillTrackDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
