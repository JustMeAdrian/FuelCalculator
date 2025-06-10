using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyMethodsController : ControllerBase
    {
        // Metoda 1: P�ijme spot�ebu paliva a ujetou vzd�lenost, vr�t� kolik je pot�eba paliva.
        [HttpGet("fuel amount")]
        public IActionResult FuelAmount(double fuelConsumtipon, double distanceDriven)
        {
            return Ok("je pot�eba " + distanceDriven * fuelConsumtipon + " l paliva");
        }

        // Metoda 2: P�ijme cenu paliva a jeho mno�stv�, vr�t� celkovou cenu paliva.
        [HttpGet("fuel cost")]
        public IActionResult FuelCost(double costOfFuel, double amountOfFuel)
        {
            return Ok("celkov� cena paliva je " + costOfFuel * amountOfFuel + "K�");
        }

        // Metoda 3: P�ijme celkovou spot�ebu paliva a ujetou vzd�lenost, vr�t� pr�m�rnou spot�ebu.
        [HttpGet("fuel consumtipon")]
        public IActionResult FuelConsumption(double consumedFuel, double distanceDriven)
        {
            double vypocet = 100 / distanceDriven;
            return Ok("pr�m�rn� spot�eba paliva je " + consumedFuel * vypocet + " l");
        }
    }
}
