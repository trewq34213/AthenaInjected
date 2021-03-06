﻿using Athena.Core.Internal.GameManager;
using Athena.Core.Internal.GameManager.IngameObjects;
using Athena.Core.Internal.Scripts;

namespace Athena.Core.Scripts.Tests
{
    public class HaveAggroTestScript : Script
    {
        public HaveAggroTestScript()
            : base("HaveAggro -> Target", "Tests")
        { }

        public override void OnStart()
        {
            if (!ObjectManager.IsInGame)
                return;

            WoWUnit tar = (WoWUnit) ObjectManager.LocalPlayer.Target;


            Print("-- Have Aggro: {0}", tar.HaveAggroWithPlayer);
            Print("-- Have Threat: {0}", tar.HaveThreatWithPlayer);
            Stop();
        }
    }
}
