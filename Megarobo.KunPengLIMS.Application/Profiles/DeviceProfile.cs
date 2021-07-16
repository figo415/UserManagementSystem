﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class DeviceProfile : Profile 
    {
        public DeviceProfile()
        {
            CreateMap<Device, DeviceDto>()
                //.ForMember(d => d.PositionText, opt => opt.MapFrom(s => s.Positions.Any() ? string.Join(',', s.Positions.Select(dp => dp.Position.Name).ToArray()) : string.Empty))
                .ForMember(d => d.PurchaseFromName, opt => opt.MapFrom(s => s.PurchaseFrom.Name))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.PurchaseFrom.Url))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()))
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));

            CreateMap<DeviceCreationDto, Device>()
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }));
            //.ForMember(d => d.Positions, opt => opt.Ignore());

            CreateMap<DeviceUpdateDto, Device>();
                //.ForMember(d => d.Positions, opt => opt.Ignore());
        }
    }
}
