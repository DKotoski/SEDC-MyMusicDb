using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicDb.Entities
{
    public class Album
    {
        public string Title { get; set; }
        public DateTime IssueDate { get; set; }
        public IPerformer Performer { get; set; }
        public List<Song> Songs { get; set; }
        public TimeSpan TotalDuration { get; set; }
    }
}