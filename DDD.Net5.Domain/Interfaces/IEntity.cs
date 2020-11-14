using System.ComponentModel.DataAnnotations;

namespace DDD.Net5.Domain.Interfaces
{
    public interface IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}