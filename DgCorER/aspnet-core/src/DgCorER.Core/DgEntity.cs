using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgCorER
{
    class DgEntity
    {
    }
    public class Person : Entity<long>, IDeletionAudited
    {
        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public long? DeleterUserId {set;get;}
        public DateTime? DeletionTime {set;get;}
        public bool IsDeleted {set;get;}

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }



}
