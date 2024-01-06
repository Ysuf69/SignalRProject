using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                Phone = createContactDto.Phone,
                FooterTitle= createContactDto.FooterTitle,
                OpenDays= createContactDto.OpenDays,
                OpenDaysDescription= createContactDto.OpenDaysDescription,
                OpenHours = createContactDto.OpenHours
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updatecontactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID = updatecontactDto.ContactID,
                Phone = updatecontactDto.Phone,
                Mail = updatecontactDto.Mail,
                Location = updatecontactDto.Location,
                FooterDescription = updatecontactDto.FooterDescription,
                FooterTitle = updatecontactDto.FooterTitle,
                OpenDays = updatecontactDto.OpenDays,
                OpenDaysDescription = updatecontactDto.OpenDaysDescription,
                OpenHours = updatecontactDto.OpenHours
            });
            return Ok("İlteişim Bilgisi Güncellendi");
        }
    }
}
