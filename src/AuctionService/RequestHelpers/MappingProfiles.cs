using AutoMapper;
using AuctionService.DTOs;
using AuctionService.Entities;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        { 
            // Map entity <-> DTO
            CreateMap<Auction, AuctionDto>();
            CreateMap<CreateAuctionDto, Auction>();
            CreateMap<UpdateAuctionDto, Auction>();
        }
    }
}
