using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class MolecularCloningProfile:Profile
    {
        public MolecularCloningProfile()
        {
            CreateMap<MolecularCloning, MolecularCloningDto>()
                .ForMember(d => d.ThicknessValue, opt => opt.MapFrom(s => s.Thickness.Value))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.Files, opt => opt.MapFrom<MoleculeFileListResolver>());

            CreateMap<MolecularCloningUpdateDto, MolecularCloning>()
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = s.ThicknessValue }))
                .ForMember(d => d.EnzymeCuttingPicture, opt => opt.MapFrom<MoleculeFileResolver>());
        }
    }

    public class MoleculeFileListResolver : IValueResolver<MolecularCloning, MolecularCloningDto, List<string>>
    {
        public List<string> Resolve(MolecularCloning source, MolecularCloningDto destination, List<string> destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.EnzymeCuttingPicture))
            {
                return new List<string>();
            }
            return source.EnzymeCuttingPicture.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class MoleculeFileResolver : IValueResolver<MolecularCloningUpdateDto, MolecularCloning, string>
    {
        public string Resolve(MolecularCloningUpdateDto source, MolecularCloning destination, string destMember, ResolutionContext context)
        {
            if(source.Files!=null && source.Files.Any())
            {
                return string.Join(',', source.Files);
            }
            return string.Empty;
        }
    }
}
