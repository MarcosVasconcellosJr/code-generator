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
    public class TerminalController : Api.Controllers.BaseControllerBase
    {
        public readonly ITerminalService _terminalService;

        public TerminalController(
            ITerminalService terminalService
            ) : base()
        {
            _terminalService = terminalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PublicTerminalDTO>> Get()
        {
            return _terminalService.GetAll().Select(PublicTerminalDTO.ConvertModelToDTO).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<PublicTerminalDTO> Get(String id)
        {
            return PublicTerminalDTO.ConvertModelToDTO(_terminalService.Get(id));
        }

        [HttpPost]
        public ActionResult<PublicTerminalDTO> Post(PrivateTerminalDTO terminal)
        {
            return PublicTerminalDTO.ConvertModelToDTO(_terminalService.Get(_terminalService.Insert(PrivateTerminalDTO.ConvertDTOToModel(terminal))));
        }

        [HttpPut("{id}")]
        public ActionResult<PublicTerminalDTO> Put(String id, PrivateTerminalDTO terminal)
        {
            terminal.Id = id;
            return PublicTerminalDTO.ConvertModelToDTO(_terminalService.Get(_terminalService.Update(PrivateTerminalDTO.ConvertDTOToModel(terminal))));
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(String id)
        {
            return _terminalService.Delete(id);
        }
    }
}
