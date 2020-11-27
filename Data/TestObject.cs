using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFormRequiredBug.Data
{
    public class TestObject
    {
        [Required]
        public string MyCrypticProperty { get; set; }
    }
}
