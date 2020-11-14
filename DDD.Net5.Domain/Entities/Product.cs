using DDD.Net5.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Net5.Domain.Entities
{
    public class Product : IEntity, IRecord, ISellable
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }
        public DateTime DeletionDate { get; set; }
        public decimal Price { get; set; }
    }
}
