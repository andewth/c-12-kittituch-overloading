using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int HealthIncrease;

    private void Start()
    {
        HealthIncrease = 20;
    }

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(HealthIncrease);
    }


}
