using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Data
{
    [Table("Cycle")]
    public class CycleEntity
    {
        public CycleEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        protected CycleEntity()
        {
        }

        [Key]
        public Guid Id { get; protected set; }

        [Required]
        [StringLength(50)]
        public string Name { get; protected set; }

        public ICollection<CycleEmployeeEntity> Employees { get; protected set; } = new List<CycleEmployeeEntity>();
    }
}
