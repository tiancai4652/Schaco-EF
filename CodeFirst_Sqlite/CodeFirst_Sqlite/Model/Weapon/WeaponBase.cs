using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Sqlite.Model.Weapon
{
    public class WeaponBase: IWeapon
    {
        public string Name { get; set; }
       
        public string ID { get; set; }

        public void Hit()
        {
            ;
        }
    }
}
