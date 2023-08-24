using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class CarController : BaseCRUDController<Cars, int, CarCreateDto, CarUpdateDto, CarInfoDto>
    {
        public CarController(ICarService service) : base(service)
        {
        }
    }
}
