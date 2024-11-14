using AutoMapper;
using WebApiLocadora.DTO;
using WebApiLocadora.Models;

namespace WebApiLocadora.Mappers
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteDTO ,Cliente>().ReverseMap();
        }
    }
}
