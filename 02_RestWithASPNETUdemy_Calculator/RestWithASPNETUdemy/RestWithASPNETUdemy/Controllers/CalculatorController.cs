using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        // Adição
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (Utilities.IsNumeric(firstNumber) && Utilities.IsNumeric(secondNumber))
            {
                var sum = Utilities.ConvertToDecimal(firstNumber) + Utilities.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // Subtração
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (Utilities.IsNumeric(firstNumber) && Utilities.IsNumeric(secondNumber))
            {
                var sub = Utilities.ConvertToDecimal(firstNumber) - Utilities.ConvertToDecimal(firstNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // Divisão
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (Utilities.IsNumeric(firstNumber) && Utilities.IsNumeric(secondNumber))
            {
                var div = Utilities.ConvertToDecimal(firstNumber) / Utilities.ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // Multiplicação
        [HttpGet("mut/{firstNumber}/{secondNumber}")]
        public IActionResult Mut(string firstNumber, string secondNumber)
        {
            if (Utilities.IsNumeric(firstNumber) && Utilities.IsNumeric(secondNumber))
            {
                var mut = Utilities.ConvertToDecimal(firstNumber) * Utilities.ConvertToDecimal(secondNumber);
                return Ok(mut.ToString());
            }
            return BadRequest("Invalid Input");
        }


    }
}
