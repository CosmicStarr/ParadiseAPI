using AutoMapper;
using ParadiseAPI.Data;
using ParadiseAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseAPI.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorsDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();

        }
    }
}
