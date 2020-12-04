using AutoMapper;
using DomainModels;
using Repositories.Data;

namespace Services.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<CycleEntity, Cycle>();
            CreateMap<CycleEmployeeEntity, CycleEmployee>();
            CreateMap<CycleReviewerEntity, CycleReviewer>();
        }
    }
}
