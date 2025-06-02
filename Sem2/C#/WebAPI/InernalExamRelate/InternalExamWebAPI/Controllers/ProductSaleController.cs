using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InternalExamWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSaleController : ControllerBase
    {
        // GET: api/<ProductSaleController>
        [HttpGet("{baseprice}/{discount}")]
        public IEnumerable<double> Get(double baseprice, double discount)
        {
            List<Double> list = new List<Double>();

            Double saleprice = baseprice - ((baseprice * discount) / 100) ;
            double GST;

            if (saleprice <= 2099)
            {
                GST = saleprice * 0.02;
            }
            else if (saleprice <= 4999)
            {
                GST = saleprice * 0.05;
            }
            else
            {
                GST = saleprice * 0.08;
            }
            Double TotalAmount = saleprice + GST;
            list.Add(saleprice);    
            list.Add(GST);
            list.Add(TotalAmount);

            return list.ToList();
        }

        // GET api/<ProductSaleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductSaleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductSaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductSaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
