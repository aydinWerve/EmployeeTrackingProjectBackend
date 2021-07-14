using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, EmployeeTrackingContext>, IDepartmentDal
    {
        public List<DepartmentDetailDto> GetDepartmentDetailDTOs()
        {
            using (EmployeeTrackingContext context = new EmployeeTrackingContext())
            {
                var result = from d in context.Departments
                             join b in context.Branches on d.BranchId equals b.Id
                             join u in context.Users on d.UserId equals u.Id
                             select new DepartmentDetailDto { BranchName = b.BranchName, DepartmentName = d.DepartmentName, FirstName = u.FirstName, LastName = u.LastName, Email = u.Email, PhoneNumber = u.PhoneNumber };
                return result.ToList();
            }
        }
    }
}
