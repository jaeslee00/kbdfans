using AutoMapper;
using Kbdfans.Models;
using Kbdfans.Dtos;

namespace Kbdfans.Profiles
{
    public class KeybaordsProfile : Profile
    {
        public KeybaordsProfile()
        {
            // Source -> Dest
            CreateMap<Keyboard, KeyboardGetDto>();
            CreateMap<KeyboardAddDto, Keyboard>();
            CreateMap<KeyboardUpdateDto, Keyboard>();
        }

    }
}