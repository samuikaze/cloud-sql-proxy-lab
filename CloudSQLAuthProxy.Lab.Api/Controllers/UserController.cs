using AutoMapper;
using CloudSQLAuthProxy.Lab.Api.Models.ViewModels;
using CloudSQLAuthProxy.Lab.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CloudSQLAuthProxy.Lab.Api.Controllers
{
    [ApiController]
    [Route("user")]
    [SwaggerTag("使用者")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(
            ILogger<UserController> logger,
            IMapper mapper,
            IUserService userService)
        {
            _logger = logger;
            _mapper = mapper;
            _userService = userService;
        }

        /// <summary>
        /// 取得所有使用者
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<List<UserViewModel>> GetUsers()
        {
            return _mapper.Map<List<UserViewModel>>(
                await _userService.GetUsers());
        }
    }
}
