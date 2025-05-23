using Microsoft.AspNetCore.Mvc;
using StakeMap.Api.Base;
using StakeMap.Core.AppMetaData;
using StakeMap.Core.Feautres.Reports.Query.Model;

namespace StakeMap.Api.Controllers
{

    [ApiController]
    public class ReportController : AppBaseController
    {
        [HttpGet(Router.Report.GetList)]
        public async Task<IActionResult> GetlistReport()
        {
            var response = await Mediator.Send(new GetAllReportQuery());
            return Ok(response);
        }
    }
}
