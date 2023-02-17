using AutoMapper;
using MediatR;
using Wallet.Application.Mapping;
using Wallet.Domain;

namespace Wallet.Application.CQRS.Querries
{
    public class GetWalletsQuery : IMapWith<Wallets>, IRequest<WalletdetailslVn>
    {
        public List<Wallets> Wallets { get; set; }
    }
}
