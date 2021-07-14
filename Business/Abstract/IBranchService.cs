using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBranchService
    {
        IDataResult<List<Branch>> GetAll();
        IDataResult<Branch> GetById(int branchId);
        IResult Add(Branch branch);
        IResult Delete(Branch branch);
        IResult Update(Branch branch);
    }
}
