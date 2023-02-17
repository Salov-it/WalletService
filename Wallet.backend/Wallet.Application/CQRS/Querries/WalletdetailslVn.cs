using AutoMapper;
using WalletService.Domain;
using WalletService.Application;

namespace WalletService.Application.CQRS.Querries
{
    public class WalletdetailslVn : IMapWith<WalletdetailslVn>
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public decimal balance { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Wallet, WalletdetailslVn>()
                .ForMember(noteVm => noteVm.id, opt => opt.MapFrom(note => note.id))
                .ForMember(noteVm => noteVm.ownerId, opt => opt.MapFrom(note => note.ownerId))
                .ForMember(noteVm => noteVm.balance, opt => opt.MapFrom(note => note.balance))
                .ForMember(noteVm => noteVm.createdAt, opt => opt.MapFrom(note => note.createdAt))
                .ForMember(noteVm => noteVm.updatedAt, opt => opt.MapFrom(note => note.updatedAt));
        }
    }
}
