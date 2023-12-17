using AutoMapper;
using Microservice.Common.Dtos;
using Microservice.DataAccess.Entities;

namespace Microservice.Business.Common.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<SampleEntity, SampleDto>();
    }
}
