using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectEmpEMS.Data;
using ProjectEmpEMS.Models;

namespace ProjectEmpEMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        private readonly DeptDbContext _context;

        public DeptsController(DeptDbContext context)
        {
            _context = context;
        }

        // GET: api/Depts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dept>>> GetDept()
        {
          if (_context.Dept == null)
          {
              return NotFound();
          }
            return await _context.Dept.ToListAsync();
        }

        // GET: api/Depts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetDept(int id)
        {
          if (_context.Dept == null)
          {
              return NotFound();
          }
            var dept = await _context.Dept.FindAsync(id);

            if (dept == null)
            {
                return NotFound();
            }

            return dept;
        }

        // PUT: api/Depts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDept(int id, Dept dept)
        {
            if (id != dept.DeptCode)
            {
                return BadRequest();
            }

            _context.Entry(dept).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeptExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Depts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dept>> PostDept(Dept dept)
        {
          if (_context.Dept == null)
          {
              return Problem("Entity set 'DeptDbContext.Dept'  is null.");
          }
            _context.Dept.Add(dept);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDept", new { id = dept.DeptCode }, dept);
        }

        // DELETE: api/Depts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDept(int id)
        {
            if (_context.Dept == null)
            {
                return NotFound();
            }
            var dept = await _context.Dept.FindAsync(id);
            if (dept == null)
            {
                return NotFound();
            }

            _context.Dept.Remove(dept);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeptExists(int id)
        {
            return (_context.Dept?.Any(e => e.DeptCode == id)).GetValueOrDefault();
        }
    }
}
