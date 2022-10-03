using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
  public static  class MapperConfig
    {
        static IEnumerable<Type> _profiles { get; set; }

        public static void ConfigureMapping(IEnumerable<Type> Profiles)
        {
            _profiles = Profiles;
            Mapper.Initialize(cfg =>
            {
                foreach (var profile in _profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

        }

    }
}
