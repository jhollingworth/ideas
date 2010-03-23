using SharpArch.Core.DomainModel;

namespace Ideas.Core
{
    public class User : Entity
    {
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string GlobalId { get; set; }
    }
}