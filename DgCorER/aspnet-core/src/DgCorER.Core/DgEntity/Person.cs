using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgCorER.DgEntity
{
    public class Person : Entity<long>, IPassivable, IDeletionAudited, IExtendableObject
    {
        private string v;

        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        //public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsActive { set; get; }

        public long? DeleterUserId { set; get; }
        public DateTime? DeletionTime { set; get; }
        public bool IsDeleted { set; get; }

        public string ExtensionData { set; get; }

        public Person()
        {
            CreationTime = DateTime.Now;
        }

        public Person(string v)
        {
            this.Name = v;
        }
    }

    public interface IFullAudited : IAudited, IDeletionAudited
    {

    }
    public interface ICreationAudited : IHasCreationTime
    {
        long? CreatorUserId { get; set; }
    }
    public interface IModificationAudited
    {
        DateTime? LastModificationTime { get; set; }
        long? LastModifierUserId { get; set; }
    }
    public interface IAudited : ICreationAudited, IModificationAudited
    {

    }


    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
    public interface IDeletionAudited : ISoftDelete
    {
        long? DeleterUserId { get; set; }
        DateTime? DeletionTime { get; set; }
    }
}
