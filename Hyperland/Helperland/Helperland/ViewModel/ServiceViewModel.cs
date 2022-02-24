using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.ViewModel
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        public string ZipcodeValue { get; set; }
        public int CityId { get; set; }
    }
}
