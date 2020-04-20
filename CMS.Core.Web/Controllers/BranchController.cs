using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Data;
using CMS.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMS.Core.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly CMSContext _context;
        public BranchController(CMSContext context)
        {
            _context = context;
        }

        // GET: api/Branches
        [HttpGet]
        public async Task<IActionResult> GetBranchItems()
        {
            var branches = await _context.Branches.ToListAsync();
            return Ok(branches);
        }

        // GET: api/Branches/branchid
        [HttpGet("{branchId}")]
        public async Task<IActionResult> GetBranchItem(int branchId)
        {
            var branch = await _context.Branches.FirstOrDefaultAsync(x => x.BranchId == branchId);
            if(branch == null)
            {
                return NotFound();
            }
            return Ok(branch);      
        }

        // PUT: api/Branches
        [HttpPut("{branchId}")]
        public async Task<ActionResult<Branch>> PutBranchItem(int branchId, Branch Branch)
        {
            if(branchId != Branch.BranchId)
            {
                return BadRequest();
            }

            _context.Entry(Branch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!Branch(branchId))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

    }
}