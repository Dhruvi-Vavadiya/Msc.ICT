using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private static List<Vehicle> _vehicals;

        public VehicleController()
        {
            if (_vehicals == null)
            {
                _vehicals = new List<Vehicle>();

                _vehicals.Add(new Vehicle { VId = 1, VName = "Suzuki", Vcolor = "Black", Vprice = 20000 });
                _vehicals.Add(new Vehicle { VId = 2, VName = "Honda", Vcolor = "Pink", Vprice = 15000 });
                _vehicals.Add(new Vehicle { VId = 3, VName = "Audi", Vcolor = "Red", Vprice = 95000 });
                _vehicals.Add(new Vehicle { VId = 4, VName = "BMW", Vcolor = "Yellow", Vprice = 57000 });

            }
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get() //1st select[Index] http://localhost:5020/api/Vehicle
        {
            return _vehicals.ToList();
        }

        [HttpPost]
        public void Post(Vehicle postvehical) //2nd create query http://localhost:5020/api/Vehicle 
        {
            _vehicals.Add(postvehical);
        }

        [HttpGet("{id}")]
        public Vehicle Get(int id) //3rd get one record select[editGET,details,deleteGET] http://localhost:5020/api/Vehicle/9
        {
            return _vehicals.FirstOrDefault(e => e.VId == id);
        }

        [HttpGet("by/{name}")]
        public IEnumerable<Vehicle> Search(string name) //search get one record select[editGET,details,deleteGET] http://localhost:5020/api/Vehicle/9
        {
            var filter = _vehicals.Where(v => v.VName == name || v.Vcolor.Contains(name));
            return filter ;
        }

        [HttpPut("{id}")]
        public void Put(int id, Vehicle vehiclestoedit) //4th edit http://localhost:5020/api/Vehicle/2?pid=2
        {
            Vehicle vehi = GetVehiID(id);
            vehi.VName = vehiclestoedit.VName;
            vehi.Vcolor = vehiclestoedit.Vcolor;
            vehi.Vprice = vehiclestoedit.Vprice;
        }

        [HttpDelete("{id}")]
        public void Delete(int id) //5th delete http://localhost:5020/api/Vehicle/2
        {
            _vehicals.Remove(GetVehiID(id));
        }

        [HttpPost("{id}/{name}/{color}/{price}")]
        public void Post(int id, string name, string color, int price) //6th create query http://localhost:5020/api/Vehicle/10/10/10/10
        {
            Vehicle veh = new Vehicle();
            veh.VId = id;
            veh.VName = name;
            veh.Vcolor = color;
            veh.Vprice = price;

            _vehicals.Add(veh);
        }

        private Vehicle GetVehiID(int id)
        {
            return _vehicals.FirstOrDefault(v => v.VId == id);
        }
        //copy paste
        [HttpGet("salary/{basic}/{da}/{ta}")]
        public double Get(int basic, float da, int ta)
        {
            return basic + (double)basic * (da / 100) + ta;
        }


    }
}
