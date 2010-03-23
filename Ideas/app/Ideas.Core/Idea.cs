using System.Collections.Generic;
using Iesi.Collections.Generic;
using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class Idea : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual ISet<Comment> Comments { get; set; }
        public virtual ISet<Vote> Votes { get; set; }
        public virtual ISet<Tag> Tags { get; set; }
        public virtual User By { get; set; }
    }
} 