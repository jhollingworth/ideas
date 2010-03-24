using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class User : Entity
    {
        public virtual string DisplayName { get; set; }
        public virtual string Email { get; set; }
        public virtual string GlobalId { get; set; }
        public virtual string PhotoUrl { get; set; }
        public virtual string Url { get; set; }
        public virtual string Provider { get; set; }
    }
}