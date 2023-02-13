﻿
using AutoMapper;

namespace Wallet.Application.Interfaces
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
