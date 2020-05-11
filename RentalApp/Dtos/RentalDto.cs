using RentalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Dtos
{
    public class RentalDto
    {
        public int Customer { get; set; }
        public List<int> Movie { get; set; }
    }
}
