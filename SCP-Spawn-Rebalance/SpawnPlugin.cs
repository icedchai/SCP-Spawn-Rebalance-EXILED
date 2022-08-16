using Exiled.API.Features;
using Exiled.Events;
using System;
using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;
using Server = Exiled.Events.Handlers.Server;
using Scp096 = Exiled.Events.Handlers.Scp096;
using ScpUpgrade = Exiled.Events.Handlers.Scp914;
using System.Collections.Generic;
using SCP_Spawn_Rebalance;
using Config = SCP_Spawn_Rebalance.Config;

namespace LoneFoundation
{

    public class SpawnPlugin : Plugin<Config>
    {

        EventHandlers EventHandler;
        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        private void RegisterEvents()
        {
            EventHandler = new EventHandlers(this);
            Server.RoundStarted += EventHandler.ServerRoundStarted;
        }
        private void UnregisterEvents()
        {
            Server.RoundStarted -= EventHandler.ServerRoundStarted;
            EventHandler = null;
        }

    }
}
