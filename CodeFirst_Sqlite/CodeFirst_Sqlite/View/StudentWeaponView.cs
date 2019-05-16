using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.View
{
    [Table("StudentWeaponView")]
    public class StudentWeaponView
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string WeaponID { get; set; }
        public string WeaponName { get; set; }
    }
}
