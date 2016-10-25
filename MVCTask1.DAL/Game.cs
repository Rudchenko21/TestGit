using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVCTask1.DAL
{
    public class Game
    {
        [Key]
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<PlatformType> PlatformType { get; set; }
        public virtual IEnumerable<Genre> Genre { get; set; }
    }
}
