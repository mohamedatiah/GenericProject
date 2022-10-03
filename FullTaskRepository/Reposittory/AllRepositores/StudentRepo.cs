using FullTaskManager.DTO;
using FullTaskRepository.Global;
using FullTaskRepository.Interfaces;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Mappers;
namespace FullTaskRepository.Reposittory
{
   public class StudentRepo
    {

        public OperationResult<StudentDTO> add()
        {
            using (var uo = new UnitOfWork<Student>())
            {
                try
                {
                   var ee= uo.PublicRepo;
                   ee.Insert(new Student() {Age=22,Name="kijgtrr" });
                    uo.DepartmentRepository.Insert(new Test() { Id = "99", Names = "testtt" });
                    var e = uo.PublicRepo.Get(a => a.Name == "ss").FirstOrDefault();
                  var dd=  e.FromEntityToDTO<Student, StudentDTO>();
                    uo.SaveChanges();

                    return new OperationResult<StudentDTO>(System.Net.HttpStatusCode.OK);
                }catch(Exception e)
                {
                    return null;
                }
            }

        }

    }
}
