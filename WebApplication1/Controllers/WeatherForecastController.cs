using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyMethodsController : ControllerBase
    {
        // Metoda 1: Pøijme spotøebu paliva a ujetou vzdálenost, vrátí kolik je potøeba paliva.
        [HttpGet("fuel amount")]
        public IActionResult FuelAmount(double fuelConsumtipon, double distanceDriven)
        {
            return Ok("je potøeba " + distanceDriven * fuelConsumtipon + " l paliva");
        }

        // Metoda 2: Pøijme cenu paliva a jeho množství, vrátí celkovou cenu paliva.
        [HttpGet("fuel cost")]
        public IActionResult FuelCost(double costOfFuel, double amountOfFuel)
        {
            return Ok("celková cena paliva je " + costOfFuel * amountOfFuel + "Kè");
        }

        // Metoda 3: Pøijme celkovou spotøebu paliva a ujetou vzdálenost, vrátí prùmìrnou spotøebu.
        [HttpGet("fuel consumtipon")]
        public IActionResult FuelConsumption(double consumedFuel, double distanceDriven)
        {
            double vypocet = 100 / distanceDriven;
            return Ok("prùmìrná spotøeba paliva je " + consumedFuel * vypocet + " l");
        }
    }
}
