using AutoMapper;
using ControlService.DTOs;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace ControlService.Controllers
{
    [ApiController]
    [Route("api/controls")]
    public class ControlsController : BaseApiController
    {
        private readonly IMapper _mapper;

        public ControlsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<Result<List<ControlDto>>> GetControls()
        {
            var controls = await DB.Find<Control>().ExecuteAsync();



            var dto = _mapper.Map<List<ControlDto>>(controls);

            return Result<List<ControlDto>>.Success(dto);
        }
    }
}