using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDb.Entities
{
    public class Song
    {
        public IPerformer Performer { get; set; }
        public Album Album { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
