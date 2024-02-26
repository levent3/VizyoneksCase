using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DtoLayer.Dtos.CategoryDtos;
using VizyoneksCase.DtoLayer.Dtos.ProductDto;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.BusinessLayer.Mapping
{
    public class MappingProfiles:Profile
    {


        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
           
 
        }

    }
}
