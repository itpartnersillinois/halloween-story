using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace halloween_story.Server.DataModels
{
    public class StoryItem
    {
        public DateTime DateCreated { get; set; }
        public int Id { get; set; }
        public string Sentence { get; set; }
    }
}