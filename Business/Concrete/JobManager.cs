using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public IDataResult<Job> GetById(string jobId)
        {
            return new SuccessDataResult<Job>(_jobDal.Get(p => p.JobId == jobId));
        }

        public IDataResult<List<Job>> GetList()
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetList().ToList());
        }

        public IResult Add(Job job)
        {
            //Business codes
            _jobDal.Add(job);
            return new Result(true, Messages.JobAdded);
        }

        public IResult Delete(Job job)
        {
            _jobDal.Delete(job);
            return new Result(true, Messages.JobDeleted);
        }

        public IResult Update(Job job)
        {
            _jobDal.Update(job);
            return new Result(true, Messages.JobUpdated);
        }
    }
}
