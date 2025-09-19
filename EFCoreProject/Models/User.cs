using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Profile Profile { get; set; }
    }

}
