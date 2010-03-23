using System;
using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class Vote : Entity
    {
        public virtual int Amount { get; set; }
        public virtual DateTime TimeVoted { get; set; }
    }
}