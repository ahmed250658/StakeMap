using Microsoft.AspNetCore.Mvc;
using StakeMap.Api.Base;
using StakeMap.Core.AppMetaData;
using StakeMap.Core.Feautres.DashBaordMatrics.Query.Model;

namespace StakeMap.Api.Controllers
{

    [ApiController]
    public class DashBoardMatricsController : AppBaseController
    {
        [HttpGet(Router.Metrics.DashBoard)]
        public async Task<IActionResult> GetlistDashBaordMastrics()
        {
            var response = await Mediator.Send(new GetAllDashboardMetricsQuery());
            return Ok(response);
        }
    }
}
