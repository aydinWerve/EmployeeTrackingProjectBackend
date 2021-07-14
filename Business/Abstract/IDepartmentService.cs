using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<Department>> GetAll();
        IDataResult<Department> GetById(int departmentId);
        IDataResult<List<DepartmentDetailDto>> GetDepartmentDetailDTOs();
        IResult Add(Department department);
        IResult Delete(Department department);
        IResult Update(Department department);
    }
}
