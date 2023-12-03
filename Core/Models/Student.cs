using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public interface IStudent
    {
        string Name { get; set; }
        string RollNo { get; set; }  

        string PhoneNumber { get; set; } 
    }
}
