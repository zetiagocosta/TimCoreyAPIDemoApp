using Microsoft.AspNetCore.Mvc;
using TimCoreyAPIDemo.Models;

namespace TimCoreyAPIDemo.Controllers.API
{
    /// <summary>
    /// Hi
    /// </summary>
    [Route("API/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<Person> users = new List<Person>();

        public UsersController(){
            users.Add(new Person { FirstName = "Jose", LastName = "Costa", Id = 1 });
            users.Add(new Person { FirstName = "Tiago", LastName = "Costa", Id = 2 });
            users.Add(new Person { FirstName = "Jose", LastName = "Tiago", Id = 3 });
        }

        // GET: api/Users
        /// <summary>
        /// Gets a list of users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return users;
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return users.Where(x => x.Id == id).First();
        }

        [HttpGet("GetFirstNames/{userId:int}/{age:int}")]
        public List<string> GetFirstNames(int userId, int age)
        {
            return users.Where(x => x.Id > userId)
                .Where(x => x.Age > age)
                .Select(x => x.FirstName).ToList();
        }

        // POST api/Users
        [HttpPost]
        public void Post(Person val)
        {
            users.Add(val);
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
