using Code.Data;
using Code.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace Code.Controllers
{
    public class ClassroomController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ClassroomController(ApplicationDbContext context)
        {
            _context = context;
        }
        // this is where i will be adding to the classroom
        [HttpPost]
        public async Task<IActionResult> Creact(Classroom classroom)
        {
            _context.Classrooms.Add(classroom);
            await _context.SaveChangesAsync();
            return Ok(classroom);
        }

    }
    // for edidt

    [HttpPut]
    public async Task<IActionResult> PutClassroom(int Id,Classroom classroom)
    {
        if (Id != classroom.Id)
        {

            return BadRequest();
        }
        _context.Entry(classroom).state = EntityState.Modified;
        await _context.SaveChanges();

        return NoContent();
    }
}
