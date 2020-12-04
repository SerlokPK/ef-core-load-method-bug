using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositories.Data
{
    public class CycleEmployeeEntity
    {
        public CycleEmployeeEntity(Guid id, Guid userId, Guid cycleId)
        {
            Id = id;
            UserId = userId;
            CycleId = cycleId;
        }

        protected CycleEmployeeEntity()
        {
        }

        [Key]
        public Guid Id { get; set; }

        public CycleEntity Cycle { get; protected set; }

        [Required]
        public Guid CycleId { get; protected set; }

        public UserEntity User { get; protected set; }

        [Required]
        public Guid UserId { get; protected set; }

        public ICollection<CycleReviewerEntity> Reviewers { get; protected set; } = new List<CycleReviewerEntity>();
    }
}
