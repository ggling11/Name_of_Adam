using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stigma_Teleport : Stigma
{
    public override void Use(BattleUnit caster)
    {
        base.Use(caster);

        caster.SetBuff(new Buff_Teleport());
    }
}
