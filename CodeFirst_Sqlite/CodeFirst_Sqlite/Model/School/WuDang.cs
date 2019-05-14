using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model
{
    [Table("WuDang")]
    public class WuDang : ISchool
    {
        public WuDang()
        {
            ID = Guid.NewGuid().ToString("N");
        }
        public string Name { get  ; set  ; }
        [Key]
        public string ID { get  ; set  ; }
        public List<Student> Students { get; set; }
    }
}
