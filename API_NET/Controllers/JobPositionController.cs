using API_NET.Models;
using API_NET.Services;
using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionController : ControllerBase
    {
        private CompanyContext _context;
        private JobPositionServices _services;

        public JobPositionController(CompanyContext context)
        {
            //_context = context;
            _services = new JobPositionServices(context);
        }

        [HttpGet]
        public IEnumerable<JobsPositions> GetJobPositions()
        {
            //_services = new JobPositionServices(_context);
            return _services.getJobPosition();
        }

        [HttpPost]
        public ResponseModels<JobsPositions> AddJobPosition(string name)
        {
            JobsPositions job = new JobsPositions();
            job.Name = name;
            return _services.addJobPosition(job);
        }

        [HttpPut]
        [Route("/api/jobPosition/{idJobPosition}")]
        public ResponseModels<JobsPositions> UpdateJobPosition(int idJobPosition, string name)
        {
            JobsPositions job = new JobsPositions();
            job.IdJobPosition = idJobPosition;
            job.Name = name;
            _services.updateJobPosition(job);
            return _services.updateJobPosition(job);
        }

        [HttpGet]
        [Route("/api/jobPosition/{idJobPosition}")]
        public JobsPositions GetJobPositionsById(int idJobPosition)
        {
            var job = new JobsPositions();
            job = _context.JobsPositions.Single(b => b.IdJobPosition == idJobPosition);
            return job;
            
        }
    
        [HttpDelete]
        [Route("/api/jobPosition/{idJobPosition}")]
        public ResponseModels<JobsPositions> DeleteJobPosition(int idJobPosition)
        {
            JobsPositions job = new JobsPositions();
            job.IdJobPosition = idJobPosition;
            return _services.deleteJobPosition(job);
        }
    }
}
