using ADN.Domain.Domain;
using ADN.Domain.DTO.Jogador;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN.Domain.Mapper
{
    public class JogadorMapperProfile : Profile
    {
        public JogadorMapperProfile()
        {
            CreateMap<Jogador, JogadorInsertDTO>().ReverseMap();
        }
    }
}
