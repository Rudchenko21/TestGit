using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
    public class Genre
    {
        [Key]
        public string Key { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Game> Game{ get; set; }
    }
}
