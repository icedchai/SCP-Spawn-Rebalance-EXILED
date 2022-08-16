using Exiled.API.Features;
using LoneFoundation;
using System;
using System.Collections.Generic;

namespace SCP_Spawn_Rebalance
{
    class EventHandlers
    {
        private readonly SpawnPlugin plugin;
        internal EventHandlers(SpawnPlugin plugin) => this.plugin = plugin;
        int spotInList = 0;
        int prioritySpot = 0;

        Random rng = new Random();


        List<Player> scps = new List<Player>();

        List<List<RoleType>> priorityList = new List<List<RoleType>>();

        bool scp049 = false;
        bool scp079 = false;
        bool scp096 = false;
        bool scp106 = false;
        bool scp173 = false;
        bool scp93953 = false;
        bool scp93989 = false;
        public void ServerRoundStarted()
        {
            priorityList.Add(plugin.Config.SpawnPriority0);
            priorityList.Add(plugin.Config.SpawnPriority1);
            priorityList.Add(plugin.Config.SpawnPriority2);
            priorityList.Add(plugin.Config.SpawnPriority3);
            foreach(Player player in Player.List)
            {

                if (player.Role.Team == Team.SCP)
                {
                    scps.Add(player);
                }
                scps.ShuffleList();
            }
            foreach(Player player in scps)
            {
                bool isFinished = false;
                while (!isFinished)
                {
                    for (; spotInList <= priorityList[prioritySpot].Count; spotInList++)
                    {
                        player.SetRole(priorityList[prioritySpot][spotInList]);
                    }
                    spotInList = 0;
                    prioritySpot++;
                    if (prioritySpot == priorityList.Count)
                    {
                        break;
                    }
                }
            }
        }
    

    }
}

