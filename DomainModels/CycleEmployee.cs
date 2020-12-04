using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class CycleEmployee
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public ICollection<CycleReviewer> Reviewers { get; set; } = new List<CycleReviewer>();
    }
}
