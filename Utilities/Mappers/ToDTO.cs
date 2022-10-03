using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AutoMapper;
using FullTaskManager.DTO;
using FullTaskRepository.Models;

namespace Utilities.Mappers
{
   public static class ToDTO
    {
  


            public static T FromEntityToDTO<T1, T>(this T1 model)
               where T : IBaseDto
               where T1 : IBaseEntity
            {
                return Mapper.Map<T1, T>(model);
            }
        public static T FromDTOToDTO<T, T1>(this T1 model)
         where T : IBaseDto
         where T1 : IBaseDto
        {
            return Mapper.Map<T1, T>(model);
        }

        public static IEnumerable<T> FromVmtoVmList<T, T1>(this List<T1> model)
               where T : IBaseDto
               where T1 : IBaseDto
            {

                return model.Select(obj => obj.FromDTOToDTO<T, T1>());

            }

        }

    }

