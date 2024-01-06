using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NatificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NatificationController : ControllerBase
    {
        private readonly INatificationService _natificationService;

        public NatificationController(INatificationService natificationService)
        {
            _natificationService = natificationService;
        }
        [HttpGet]
        public IActionResult NatificationList()
        {
            return Ok(_natificationService.TGetListAll());
        }

        [HttpGet("NatificationCountByStatusFalse")]
        public IActionResult TNatificationCountByStatusFalse()
        {
            return Ok(_natificationService.TNatificationCountByStatusFalse());
        }
        [HttpGet("GetAllNatificationByFalse")]
        public IActionResult GetAllNatificationByFalse()
        {
            return Ok(_natificationService.TGetAllNatificationByFalse());
        }
        [HttpPost]
        public IActionResult CreateNatification(CreateNatificationDto createNatificationDto)
        {
            Natification natification = new Natification()
            {
                Description = createNatificationDto.Description,
                Icon = createNatificationDto.Icon,
                Status = false,
                Type = createNatificationDto.Type,
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            };
            _natificationService.TAdd(natification);
            return Ok("Ekleme İşlemi Yapıldı");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNatification(int id)
        {
            var value=_natificationService.TGetByID(id);
            _natificationService.TDelete(value);
            return Ok("Bildirim  Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetNatification(int id)
        {
            var value = _natificationService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]
        public IActionResult UpdateNatification(UpdateNatificationDto updateNatificationDto)
        {
            Natification natification = new Natification()
            {
                NatificationID=updateNatificationDto.NatificationID,
                Description = updateNatificationDto.Description,
                Icon = updateNatificationDto.Icon,
                Status = updateNatificationDto.Status,
                Type = updateNatificationDto.Type,
                Date = updateNatificationDto.Date
            };
            _natificationService.TUpdate(natification);
            return Ok("Güncelleme İşlemi Yapıldı");
        }

        [HttpGet("NatificationStatusChangeToFalse/{id}")]
        public IActionResult NatificationStatusChangeToFalse(int id)
        {
            _natificationService.TNatificationStatusChangeToFalse(id);
            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("NatificationStatusChangeToTrue/{id}")]
        public IActionResult NatificationStatusChangeToTrue(int id)
        {
            _natificationService.TNatificationStatusChangeToTrue(id);
            return Ok("Güncelleme Yapıldı");
        }
    }
}
