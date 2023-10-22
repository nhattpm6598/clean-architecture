using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE.Eco.PaymentProcessing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DemoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Demo()
        {
            await _unitOfWork.DBMaster.PaymentToken.DemoConnect();
             _unitOfWork.DBPartner.ClearRepos();
            await _unitOfWork.DBPartner.PartnerWalletHistory.DemoConnect();
            return Ok();
        }
    }
}
