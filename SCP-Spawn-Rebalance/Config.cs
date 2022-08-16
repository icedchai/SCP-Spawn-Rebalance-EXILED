using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_Spawn_Rebalance
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public List<RoleType> SpawnPriority0 { get; set; } = new List<RoleType>
        {
            RoleType.Scp93953,
            RoleType.Scp93989,
            RoleType.Scp049
        };
        public List<RoleType> SpawnPriority1 { get; set; } = new List<RoleType> 
        { 
            RoleType.Scp079, 
        };
        public List<RoleType> SpawnPriority2 { get; set; } = new List<RoleType>
        {
            RoleType.Scp096,
            RoleType.Scp106
        };
        public List<RoleType> SpawnPriority3 { get; set; } = new List<RoleType>
        {

        };

    }
}
