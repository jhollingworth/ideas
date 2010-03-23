using System.Collections.Generic;
using Iesi.Collections.Generic;
using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class Tag : Entity
    {
        public virtual string Text { get; set; }
        public virtual ISet<Idea> Ideas { get; set; }
    }
}