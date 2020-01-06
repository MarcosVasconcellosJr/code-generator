using System;
using System.Collections.Generic;
using System.Linq;
using Api.DTO;
using Domain.Model;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Api.Entities.DTO;
using Microsoft.AspNetCore.Authorization;

namespace Api.Entities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HAUHAUHAUController : Api.Controllers.BaseControllerBase
    {
        public readonly IHAUHAUHAUService _hauhauhauService;

        public HAUHAUHAUController(
            IHAUHAUHAUService hauhauhauService
            ) : base()
        {
            _hauhauhauService = hauhauhauService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PublicHAUHAUHAUDTO>> Get()
        {
            return _hauhauhauService.GetAll().Select(PublicHAUHAUHAUDTO.ConvertModelToDTO).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<PublicHAUHAUHAUDTO> Get(String id)
        {
            return PublicHAUHAUHAUDTO.ConvertModelToDTO(_hauhauhauService.Get(id));
        }

        [HttpPost]
        public ActionResult<PublicHAUHAUHAUDTO> Post(PrivateHAUHAUHAUDTO hauhauhau)
        {
            return PublicHAUHAUHAUDTO.ConvertModelToDTO(_hauhauhauService.Get(_hauhauhauService.Insert(PrivateHAUHAUHAUDTO.ConvertDTOToModel(hauhauhau))));
        }

        [HttpPut("{id}")]
        public ActionResult<PublicHAUHAUHAUDTO> Put(String id, PrivateHAUHAUHAUDTO hauhauhau)
        {
            hauhauhau.Id = id;
            return PublicHAUHAUHAUDTO.ConvertModelToDTO(_hauhauhauService.Get(_hauhauhauService.Update(PrivateHAUHAUHAUDTO.ConvertDTOToModel(hauhauhau))));
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(String id)
        {
            return _hauhauhauService.Delete(id);
        }
    }
}
