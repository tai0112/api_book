using AutoMapper;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using Microsoft.AspNetCore.Identity;

namespace HiNetProjectApi.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Genre mapper
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<AddRequestGenreDTO, Genre>().ReverseMap();
            CreateMap<UpdateRequestGenreDTO, Genre>().ReverseMap();

            //Age rating mapper
            CreateMap<AgeRatingDTO, AgeRating>().ReverseMap();
            CreateMap<AddAgeRatingRequestDTO, AgeRating>().ReverseMap();
            CreateMap<UpdateAgeRatingRequestDTO, AgeRating>().ReverseMap();

            //SubGenre mapper
            CreateMap<SubGenre, SubGenreDTO>().ReverseMap();
            CreateMap<AddSubGenreRequestDTO, SubGenre>().ReverseMap();
            CreateMap<UpdateSubGenreRequestDTO, SubGenre>().ReverseMap();

            //Cover type mapper
            CreateMap<CoverTypeDTO, CoverType>().ReverseMap();
            CreateMap<AddCoverTypeRequestDTO, CoverType>().ReverseMap();
            CreateMap<UpdateCoverTypeRequestDTO, CoverType>().ReverseMap();

            //Cart mapper
            CreateMap<CartDTO, Cart>().ReverseMap();
            CreateMap<UpdateCartRequestDTO, Cart>().ReverseMap();
            CreateMap<AddCartRequestDTO, Cart>().ReverseMap();
            CreateMap<AddCartRequestDTO, UpdateCartRequestDTO>().ReverseMap();

            //CartDetail mapper
            CreateMap<CartDetailDTO, CartDetail>().ReverseMap();
            CreateMap<UpdateCartDetailRequestDTO, CartDetail>().ReverseMap();
            CreateMap<AddCartDetailRequestDTO, CartDetail>().ReverseMap();

            //Book mapper
            CreateMap<BookDTO, Book>().ReverseMap();
            CreateMap<UpdateBookRequestDTO, Book>().ReverseMap();
            CreateMap<AddBookRequestDTO, Book>().ReverseMap();

            //User mapper
            CreateMap<RegisterUserRequestDTO, ApplicationUser>().ReverseMap();
            CreateMap<UserDTO, ApplicationUser>().ReverseMap();
            CreateMap<UpdateUserRequestDTO, ApplicationUser>().ReverseMap();

            //Publisher mapper
            CreateMap<PublisherDTO, Publisher>().ReverseMap();
            CreateMap<AddPublisherRequestDTO, Publisher>().ReverseMap();
            CreateMap<UpdatePublisherRequestDTO, Publisher>().ReverseMap();

            //Stock quantities
            CreateMap<StockQuantityDTO, StockQuantity>().ReverseMap();
            CreateMap<AddStockQuantityDTO, StockQuantity>().ReverseMap();
            CreateMap<UpdateStockQuantityRequestDTO, StockQuantity>().ReverseMap();

            //User
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
            CreateMap<ApplicationUser, RegisterUserRequestDTO>().ReverseMap();
            CreateMap<ApplicationUser, UpdateUserRequestDTO>().ReverseMap();


        }
    }
}
