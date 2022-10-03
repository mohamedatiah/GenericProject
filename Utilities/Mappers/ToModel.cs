using AutoMapper;
using FullTaskManager.DTO;
using FullTaskRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Mappers
{
  public static  class ToModel
    {
        public static T FromDTOToEntity<T1, T>(this T1 viewModel)
    where T1 : IBaseDto
    where T : IBaseEntity
        {
            return Mapper.Map<T1, T>(viewModel);
        }
        public static IEnumerable<T> ToEntityList<T, T1>(this IEnumerable<T1> viewModel)
            where T1 : IBaseDto
            where T : class

        {
            return Mapper.Map<IEnumerable<T1>, IEnumerable<T>>(viewModel);
        }
    }
}
