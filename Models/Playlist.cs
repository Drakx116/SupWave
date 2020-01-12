using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupWave.Models
{
    public class Playlist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
