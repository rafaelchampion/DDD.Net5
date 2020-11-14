using System;

namespace DDD.Net5.Domain.Interfaces
{
    public interface IRecord
    {
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }
        public DateTime DeletionDate { get; set; }
    }
}