using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace halloween_story.Server.DataModels
{
    public class StoryItem : System.IEquatable<StoryItem>
    {
        public DateTime DateCreated { get; set; }
        public int Id { get; set; }
        public string Sentence { get; set; }

        public bool Equals([AllowNull] StoryItem other)
        {
            return this.Sentence.ToLowerInvariant() == other.Sentence.ToLowerInvariant();
        }

        public override bool Equals(object obj)
        {
            return this == null ? false : this.Sentence.Equals(((StoryItem)obj).Sentence);
        }

        public override int GetHashCode()
        {
            return this == null || string.IsNullOrWhiteSpace(this.Sentence) ? 0 : this.Sentence.GetHashCode();
        }
    }
}