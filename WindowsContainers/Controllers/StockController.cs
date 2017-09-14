using System.Collections.Generic;
using WindowsContainers.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WindowsContainers.Controllers
{
    [Route("api/[controller]")]
    public class StockController : Controller
    {
        private readonly IStockRepository m_StockRepository;

        public StockController()
        {
            m_StockRepository = new StockRepository();
        }

        // GET: api/stock
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/stock/1
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return m_StockRepository.GetQuantity(id).ToString();
        }

        // POST api/stock
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/stock/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
