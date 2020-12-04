using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Data
{
    [Table("Users")]
    public class UserEntity
    {
        public UserEntity(Guid id, string email, bool isDeleted)
        {
            UserId = id;
            Email = email.ToLower();
            IsDeleted = isDeleted;
        }

        protected UserEntity()
        {
        }

        [Key]
        public Guid UserId { get; protected set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; protected set; }

        [Required]
        public bool IsDeleted { get; protected set; }

        public ICollection<CycleReviewerEntity> CycleReviewers { get; protected set; } = new List<CycleReviewerEntity>();

        public ICollection<CycleEmployeeEntity> CycleEmployees { get; protected set; } = new List<CycleEmployeeEntity>();
    }
}
