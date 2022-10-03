using AutoMapper;
using FullTaskManager.DTO;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Mappers.Profiles.FromEntity
{
    public class FromStudentToStudentDTO : Profile
    {
        public FromStudentToStudentDTO()
        {
            CreateMap<StudentDTO, Student>();
        }
    }
}
