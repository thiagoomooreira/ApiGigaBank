using System.Collections.Generic;
using AutoMapper;
using GigaBank.Dtos;
using GigaBank.Dtos.Response;
using GigaBank.Models;

namespace GigaBank.Mappings
{
    public class EntidadesParaDtosMappingProfile: Profile
    {
        public EntidadesParaDtosMappingProfile()
        {
            CreateMap<ContaCorrenteDto, ContaCorrente>();
            CreateMap<ContaCorrente, ContaCorrenteResponse>();
        }
    }
}