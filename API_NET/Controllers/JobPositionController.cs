﻿using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionController : ControllerBase
    {
        private CompanyContext _context;

        public JobPositionController(CompanyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<JobsPositions> GetJobPositions() => _context.JobsPositions.ToList();

        [HttpPost]
        public bool AddJobPosition(JobsPositions job)
        {
            _context.JobsPositions.Add(job);
            _context.SaveChanges();
            return true;
        }

        [HttpPut]
        public bool UpdateJobPosition(JobsPositions job)
        {
            _context.JobsPositions.Update(job);
            _context.SaveChanges();
            return true;
        }

        [HttpGet]
        [Route("/api/jobPosition/{id}")]
        public JobsPositions GetJobPositionsById(int id)
        {
            var job = new JobsPositions();
            job = _context.JobsPositions.Single(b => b.IdJobPosition == id);
            return job;
            
        }
    }
}
