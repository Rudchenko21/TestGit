using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask1.DAL
{
    public class Comment
    {
        [Key]
        public int Key { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual Game Game { get; set; }
    }
}
