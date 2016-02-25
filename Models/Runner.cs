using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trails.Models
{
    public class Runner
    {
        public Runner()
        {
        }
        
        public int Id { get; set; }
        
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        
        public int Age { get; set; }
        
        public string FavouriteBeer { get; set; }
        
    }
}
