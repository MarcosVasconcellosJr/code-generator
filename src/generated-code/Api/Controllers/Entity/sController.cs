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
    public class sController : Api.Controllers.BaseControllerBase
    {
        public readonly IsService _sService;

        public sController(
            IsService sService
            ) : base()
        {
            _sService = sService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PublicsDTO>> Get()
        {
            return _sService.GetAll().Select(PublicsDTO.ConvertModelToDTO).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<PublicsDTO> Get(String id)
        {
            return PublicsDTO.ConvertModelToDTO(_sService.Get(id));
        }

        [HttpPost]
        public ActionResult<PublicsDTO> Post(PrivatesDTO s)
        {
            return PublicsDTO.ConvertModelToDTO(_sService.Get(_sService.Insert(PrivatesDTO.ConvertDTOToModel(s))));
        }

        [HttpPut("{id}")]
        public ActionResult<PublicsDTO> Put(String id, PrivatesDTO s)
        {
            s.Id = id;
            return PublicsDTO.ConvertModelToDTO(_sService.Get(_sService.Update(PrivatesDTO.ConvertDTOToModel(s))));
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(String id)
        {
            return _sService.Delete(id);
        }
    }
}
