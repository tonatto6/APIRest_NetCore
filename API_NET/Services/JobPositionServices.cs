using API_NET.Models;
using DB;

namespace API_NET.Services
{
    public class JobPositionServices
    {
        private CompanyContext _context;
        private ResponseModels<JobsPositions> _response;
        private ResponseError _error;

        public JobPositionServices(CompanyContext context)
        {
            _context = context;
            _response = new ResponseModels<JobsPositions>();
        }

        public IEnumerable<JobsPositions> getJobPosition()
        {
            return _context.JobsPositions.ToList();
        }
    
        public ResponseModels<JobsPositions> addJobPosition(JobsPositions job)
        {
            int countJobs = _context.JobsPositions.Count(b => b.Name == job.Name);
            if (countJobs > 0)
            {
                _response.StatusCode = 422;
                _response.Error = true;
                _response.Body = job;
                return _response;
            }
            _context.JobsPositions.Add(job);
            _context.SaveChanges();
            _response.Body = job;
            return _response;
        }
    
        public ResponseModels<JobsPositions> deleteJobPosition(JobsPositions job)
        {
            int countJob = _context.JobsPositions.Count(b => b.IdJobPosition == job.IdJobPosition);
            if (countJob == 0)
            {
                //_response = new ResponseError();
                _response.StatusCode = 422;
                _response.Error = true;
                _response.Body = job;
                //_error.Body = "El puesto de trabajo ingresado no existe";
                //throw new Exception(_error);
                return _response;
            }
            _context.JobsPositions.Remove(job);
            _context.SaveChanges();
            _response.Body = job;
            return _response;

        }
    
        public ResponseModels<JobsPositions> updateJobPosition(JobsPositions job)
        {
            int countJob = _context.JobsPositions.Count(b => b.IdJobPosition == job.IdJobPosition);
            if (countJob == 0)
            {
                _response.StatusCode = 422;
                _response.Error = true;
                _response.Body = job;
                return _response;
            }
            _context.JobsPositions.Update(job);
            _context.SaveChanges();
            _response.Body = job;
            return _response;
        }
    }
}
