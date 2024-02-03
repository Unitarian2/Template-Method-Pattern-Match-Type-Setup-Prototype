using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragilePlayerSetupHandler : BaseMatchSetupHandler
{
    public FragilePlayerSetupHandler(GameSetupManager gameSetupManager) : base(gameSetupManager) { }

    public override void SetupMagicCircleLifeSpan(List<MagicCircleDataSO> magicCircleDataSOList)
    {
        //De�i�ikli�e gerek yok
    }

    public override void SetupPlayerStats(PlayerStats playerStats)
    {
        playerStats.maxHealth *= 0.75f;
        
    }
}
