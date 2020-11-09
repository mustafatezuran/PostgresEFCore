using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IJobService
    {
        IDataResult<List<Job>> GetList();
        IDataResult<Job> GetById(string jobId);
        IResult Add(Job job);
        IResult Delete(Job job);
        IResult Update(Job job);
    }
}
