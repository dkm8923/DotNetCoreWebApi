using AutoMapper;
using DotNetCoreWebApi.Services.Common.Data;
using DotNetCoreWebApi.Services.Common.Dtos;
using DotNetCoreWebApi.Services.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCoreWebApi.Services.Common.Controllers
{
    //api/address
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ApiController
    {
        private readonly ICommonRepo _repository;
        private readonly IMapper _mapper;

        public AddressController(ICommonRepo repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns all Addresses in DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<AddressReadDto>> GetAllAddresses()
        {
            var ret = _repository.GetAllAddresses();
            return Ok(_mapper.Map<IEnumerable<AddressReadDto>>(ret));
        }

        /// <summary>
        /// Returns specific Address record from DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetAddressById")]
        public ActionResult<AddressReadDto> GetAddressById(int id)
        {
            var ret = _repository.GetAddressById(id);

            if (ret != null)
            {
                return Ok(_mapper.Map<AddressReadDto>(ret));
            }

            return NotFound();
        }

        /// <summary>
        /// Creates a specific Address
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Address
        ///     {
        ///        "address1": "5774 E. Wallings Rd",
        ///        "address2": "Deliver To Side Door",
        ///        "city": "Broadview Heights",
        ///        "stateId": 1,
        ///        "postalCode": 44147
        ///     }
        ///
        /// </remarks>
        /// <param name="req"></param>
        /// <returns>A newly created Address</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>   
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<AddressReadDto> CreateAddress(AddressCreateDto req)
        {
            var addressModel = _mapper.Map<Address>(req);

            _repository.CreateAddress(addressModel);
            _repository.SaveChanges();

            var addressReadDto = _mapper.Map<AddressReadDto>(addressModel);
            return CreatedAtRoute(nameof(GetAddressById), new { Id = addressReadDto.Id }, addressReadDto);
        }

        /// <summary>
        /// Updates a specific Address
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult UpdateAddress(int id, AddressUpdateDto req)
        {
            var addressModelFromRepo = _repository.GetAddressById(id);
            if (addressModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(req, addressModelFromRepo);

            _repository.UpdateAddress(addressModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// Deletes a specific Address
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteAddress(int id)
        {
            var addressModelFromRepo = _repository.GetAddressById(id);
            if (addressModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteAddress(addressModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}