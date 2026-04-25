using AspCoreWebApiCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly SchoolContext _contx;
        public StudentApiController(SchoolContext context)
        {
            _contx = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await _contx.Students.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var stud = await _contx.Students.FindAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            return Ok(stud);
        }
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student std)
        {
            await _contx.Students.AddAsync(std);
            await _contx.SaveChangesAsync();
            return Ok(std);
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<Student>> UpdateStudent(int id, Student std)
        { 
            if(id != std.Id)
            {
                return BadRequest();
            }
            _contx.Entry(std).State = EntityState.Modified;
            await _contx.SaveChangesAsync();
            return Ok(std);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var std = await _contx.Students.FindAsync(id);
            if(std == null)
            {
                return NotFound();
            }
            _contx.Students.Remove(std);
            await _contx.SaveChangesAsync();
            return Ok(std);
        }


    }
}
