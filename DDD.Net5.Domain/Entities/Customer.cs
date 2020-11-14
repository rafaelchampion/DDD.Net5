using DDD.Net5.Domain.Interfaces;
using System;

namespace DDD.Net5.Domain.Entities
{
    public class Customer : IEntity, IRecord, IBillable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }
        public DateTime DeletionDate { get; set; }
    }
}
