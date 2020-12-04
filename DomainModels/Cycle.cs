using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class Cycle
    {
        public Guid Id { get; set; }

        public ICollection<CycleEmployee> Employees { get; set; } = new List<CycleEmployee>();
    }
}
