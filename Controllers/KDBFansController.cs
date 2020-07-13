using System.Collections.Generic;
using AutoMapper;
using Kbdfans.Repository;
using Kbdfans.Dtos;
using Kbdfans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kbdfans.Controllers
{
    [Route("api/keyboards")]
    [ApiController]
    public class KeyboardsController : ControllerBase
    {
        private readonly IKbdfansRepo _repository;
        private readonly IMapper _mapper;

        public KeyboardsController(IKbdfansRepo repository, IMapper mapper) //dependency injections here! for instance creation
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/keyboards
        [HttpGet]
        public ActionResult <IEnumerable<KeyboardGetDto>> GetAllKeyboards()
        {
            var keyboardItems = _repository.GetAllKeyboards();
            return Ok(_mapper.Map<IEnumerable<KeyboardGetDto>>(keyboardItems));
        }

        //GET api/keyboards/{id}
        [HttpGet("{id}", Name="GetKeyboardById")]
        public ActionResult <KeyboardGetDto> GetKeyboardById(int id)
        {
            var keyboardItem = _repository.GetKeyboardById(id);
            if (keyboardItem != null)
            {
                return Ok(_mapper.Map<KeyboardGetDto>(keyboardItem));
            }
            return NotFound();
        }
        public ContentResult()
        {
            return Content("fuck you")
        }
        //POST api/keyboards
        [HttpPost]
        public ActionResult <KeyboardGetDto> AddKeyboard(KeyboardAddDto dto)
        {
            var keyboardInfo = _mapper.Map<Keyboard>(dto);
            _repository.AddKeyboard(keyboardInfo);
            _repository.SaveChanges();

            var keyboardGetDto = _mapper.Map<KeyboardGetDto>(keyboardInfo);

            //return Ok(keyboardGetDto);
            return CreatedAtRoute(nameof(GetKeyboardById), new {Id = keyboardGetDto.Id}, keyboardGetDto);
        }

        //PATCH api/keyboards/{id}
        [HttpPatch("{id}")]
        public ActionResult UpdateKeyboard(int id, KeyboardUpdateDto kbd)
        {
            var keyboardInfo = _repository.GetKeyboardById(id);
            if (keyboardInfo == null)
            {
                return NotFound();
            }
            _mapper.Map(kbd, keyboardInfo);
            _repository.UpdateKeyboard(keyboardInfo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}