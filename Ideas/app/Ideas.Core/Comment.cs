using System;
using Iesi.Collections.Generic;
using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class Comment : Entity
    {
        public virtual string Text { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual User By { get; set; }
        public virtual ISet<Vote> Votes { get; set; }
    }
}