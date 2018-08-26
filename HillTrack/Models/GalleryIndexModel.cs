using System.Collections.Generic;
using HillTrack.Data.Models;

namespace HillTrack.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
