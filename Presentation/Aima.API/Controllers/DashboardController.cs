using Aima.Application.Enums;
using Aima.Application.Helpers;
using Aima.Application.Interfaces;
using Aima.Application.Models;
using Aima.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : CustomBaseController
    {
        private ResponseModel _response;
        private IFileManager _fileManager;

        public DashboardController(IFileManager fileManager)
        {
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }
    }
}
