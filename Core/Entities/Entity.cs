using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            if(ReferenceEquals(null, other)) return false;
            if(ReferenceEquals(this, other)) return true;
            if(obj.GetType() != typeof(Entity)) return false;
            if(Id<=0) return false;

            return Id == other.Id;
        }
      
        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }


    }
}
