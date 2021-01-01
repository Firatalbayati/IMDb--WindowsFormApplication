using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinİmDb
{
    class Role
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public List<MovieCastRole> movieCastRoles { get; set; }


    }
}
