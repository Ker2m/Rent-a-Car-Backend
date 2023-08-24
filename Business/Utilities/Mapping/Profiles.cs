using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Request.Functional;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //Kullanıcı ekleme
        CreateMap<RegisterDto, User>();

        //Kullanıcı güncelleme (Bu fonksiyon eklenmemişti onu ekledim)
        CreateMap<UserUpdateDTO, User>();

        //Kullanıcı görüntüleme
        CreateMap<User, Models.Response.UserProfileDto>();

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //Araç ekleme
        CreateMap<CarCreateDto, Cars>();

        //Araç güncelleme (Bu fonksiyon eklenmemişti onu ekledim)
        CreateMap<CarUpdateDto, Cars>();

        //Araç görüntüleme
        CreateMap<Cars, CarInfoDto>();

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //Rezervasyon ekleme
        CreateMap<ReservationCreateDto,Reservations>();

        //Rezervasyon güncelleme
        CreateMap<ReservationUpdateDto,Reservations>();

        //Rezervasyon görüntüleme
        CreateMap<Reservations, ReservationInfoDto>();

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //Yorum ekleme
        CreateMap<CommentCreateDto, Comment>();

        //Yorum güncelleme
        CreateMap<CommentUpdateDto, Comment>();

        //Yorum görüntüleme
        CreateMap<Comment, CommentInfoDto>();

    }
}