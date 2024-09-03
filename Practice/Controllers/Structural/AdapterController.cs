using Adapter;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdapterController : ControllerBase
    {

        private readonly ILogger<AdapterController> _logger;
        private readonly ITarget _billing;

        public AdapterController(ILogger<AdapterController> logger, ITarget billing)
        {
            _logger = logger;
            _billing = billing;
        }

        [HttpGet(Name = "Adapter")]
        public IActionResult Get()
        {
            //Storing the Employees Data in a String Array
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            _logger.LogInformation("HR system passes employee string array to Adapter");
            var result = _billing.ProcessCompanySalary(employeesArray);
            _logger.LogInformation("Salary process by third party billing system using Adapter");

            return Ok(result);
        }
    }
}
