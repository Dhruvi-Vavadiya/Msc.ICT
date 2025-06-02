using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForInternalExampleController : ControllerBase
    {
        public static List<Vehicle> _vehicles;

        public ForInternalExampleController()
        {
            if(_vehicles == null)
            {
                _vehicles = new List<Vehicle>();

                _vehicles.Add(new Vehicle { VId = 5, VName = " abc" ,Vcolor = "abc" ,Vprice = 500});
                _vehicles.Add(new Vehicle { VId = 3, VName = "yyyy", Vcolor = "yyy", Vprice = 500 });
                _vehicles.Add(new Vehicle { VId = 2, VName = "lll", Vcolor = "lllll", Vprice = 500 });
                _vehicles.Add(new Vehicle { VId = 2, VName = "kkkk", Vcolor = "kkk", Vprice = 500 });
            }
        }
        // GET: api/<ForInternalExampleController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _vehicles.ToList();
        }

        // GET api/<ForInternalExampleController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _vehicles.FirstOrDefault(v => v.VId == id);
        }

        // POST api/<ForInternalExampleController>
        [HttpPost]
        public void Post(Vehicle vehi)
        {
            _vehicles.Add(vehi);
        }

        // PUT api/<ForInternalExampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, Vehicle vehi)
        {
            Vehicle vehicle = _vehicles.FirstOrDefault(v => v.VId == id);

            vehicle.VId = vehi.VId;
            vehicle.VName = vehi.VName;
            vehicle.Vprice = vehi.Vprice;
            vehicle.Vcolor = vehi.Vcolor;
        }

        // DELETE api/<ForInternalExampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //remove al 2 vID
            _vehicles.Remove(_vehicles.Find(v => v.VId == id));
        }


        [HttpGet("salary/{basic}/{da}/{ta}")]
        public double Get(int basic, float da, int ta)
        {
            return basic + (double)basic * (da / 100) + ta;
        }







    }
}
