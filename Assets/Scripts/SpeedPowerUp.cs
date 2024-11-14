using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    public float SpeedMultiplier = 2.0f;
    public float Duration = 5.0f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(SpeedMultiplier, Duration);
    }
}
