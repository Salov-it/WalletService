using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Wallet.Application.CQRS.command;
using Wallet.infrastructure;

namespace Wallet.Application.CQRS.Querries
{
    public class GetWalletHandler : IRequestHandler<GetWalletsQuery, WalletdetailslVn>
    {
        
        public readonly IMapper mapper;
        
        public async Task<WalletdetailslVn> Handle(GetWalletsQuery request, CancellationToken cancellationToken)
        {
           


            return ;
        }
    }
}