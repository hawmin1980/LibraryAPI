// Mapping/MemberProfile.cs
using AutoMapper;
using LibraryAPI.Models.Entities;
using LibraryAPI.DTOs;

namespace LibraryAPI.Mapping
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<Member, MemberDto>();
            CreateMap<CreateMemberDto, Member>();
        }
    }
}
