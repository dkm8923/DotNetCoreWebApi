using AutoMapper;
using DotNetCoreWebApi.Services.Common.Data;
using DotNetCoreWebApi.Services.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DotNetCoreWebApi.Services.Common.Dtos;

namespace DotNetCoreWebApi.Services.Common.Controllers
{
    //api/usastates
    [Route("api/[controller]")]
    [ApiController]
    public class UsaStateController : ControllerBase 
    {
        private readonly ICommonRepo _repository;
        private readonly IMapper _mapper;

        public UsaStateController(ICommonRepo repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/usastateses
        [HttpGet]
        public ActionResult <IEnumerable<UsaStateReadDto>> GetAllUsaStates() 
        {
            var ret = _repository.GetAllUsaStates();
            return Ok(_mapper.Map<IEnumerable<UsaStateReadDto>>(ret));
        }

        //GET api/usastateses/5
        [HttpGet("{id}", Name="GetUsaStateById")]
        public ActionResult<UsaStateReadDto> GetUsaStateById(int id)
        {
            var ret = _repository.GetUsaStateById(id);
            
            if (ret != null) 
            {
                return Ok(_mapper.Map<UsaStateReadDto>(ret));
            }
            
            return NotFound();
        }

        //POST api/usastateses
        [HttpPost]
        public ActionResult<UsaStateReadDto> CreateUsaState(UsaStateCreateDto req)
        {
            var usastatesModel = _mapper.Map<UsaState>(req);

            _repository.CreateUsaState(usastatesModel);
            _repository.SaveChanges();

            var usastatesReadDto = _mapper.Map<UsaStateReadDto>(usastatesModel);
            return CreatedAtRoute(nameof(GetUsaStateById), new {Id = usastatesReadDto.Id}, usastatesReadDto);
        }

        //POST api/usastateses
        [HttpPut("{id}")]
        public ActionResult UpdateUsaState(int id, UsaStateUpdateDto req)
        {
            var usastatesModelFromRepo = _repository.GetUsaStateById(id);
            if (usastatesModelFromRepo == null) 
            {
                return NotFound();
            }

            _mapper.Map(req, usastatesModelFromRepo);

            _repository.UpdateUsaState(usastatesModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete api/usastateses
        [HttpDelete("{id}")]
        public ActionResult DeleteUsaState(int id)
        {
            var usastatesModelFromRepo = _repository.GetUsaStateById(id);
            if (usastatesModelFromRepo == null) 
            {
                return NotFound();
            }

            _repository.DeleteUsaState(usastatesModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}