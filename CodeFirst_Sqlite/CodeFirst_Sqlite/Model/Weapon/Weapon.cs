using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model.Weapon
{
    [Table("Weapon")]
    public class Weapon
    {
        public Weapon()
        {
            ID = Guid.NewGuid().ToString("N");
        }

        public int Type { get; set; }

        public string Name { get; set; }
       
        public string ID { get; set; }

        public void Hit()
        {
            ;
        }
    }
}
