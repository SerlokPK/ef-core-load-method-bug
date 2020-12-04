using AutoMapper;
using Common;
using Common.Helpers;
using DomainModels;
using Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repositories.Data;
using Repositories.Extensions;
using System;
using System.Linq;

namespace Repositories.UserRepo
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly string _userPath = $"{nameof(CycleEntity.Employees)}.{nameof(CycleEmployeeEntity.User)}";
        private readonly string _reviewerPath = $"{nameof(CycleEntity.Employees)}.{nameof(CycleEmployeeEntity.Reviewers)}.{nameof(CycleReviewerEntity.User)}";

        private readonly IMapper _mapper;

        public UserRepository(IOptions<AppSettings> options, IMapper mapper) : base(options)
        {
            DependencyHelper.ThrowIfNull(options, mapper);

            _mapper = mapper;
        }

        public Cycle GetWithInclude()
        {
            using (var context = GetContext())
            {
                var cycle = context.Cycles.Include(_userPath).Include(_reviewerPath)
                    .SingleOrDefault(x => x.Name == "name-0");

                return _mapper.Map<Cycle>(cycle);
            }
        }

        public Cycle GetWithLoad()
        {
            using (var context = GetContext())
            {
                var includePaths = new string[] { _userPath, _reviewerPath };
                var query = context.Cycles;
                var cycle = query.SingleOrDefault(x => x.Name == "name-0");
                query.LoadMultipleProperties(includePaths);

                return _mapper.Map<Cycle>(cycle);
            }
        }
    }
}
