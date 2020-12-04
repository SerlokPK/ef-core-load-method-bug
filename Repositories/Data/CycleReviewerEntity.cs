using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Data
{
    [Table("CycleReviewer")] 
    public class CycleReviewerEntity
    {
        public CycleReviewerEntity(Guid id, Guid cycleEmployeeId, Guid userId)
        {
            Id = id;
            CycleEmployeeId = cycleEmployeeId;
            UserId = userId;
        }

        public CycleReviewerEntity()
        {
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CycleEmployeeId { get; protected set; }

        public CycleEmployeeEntity CycleEmployee { get; protected set; }

        public UserEntity User { get; protected set; }

        [Required]
        public Guid UserId { get; protected set; }
    }
}
