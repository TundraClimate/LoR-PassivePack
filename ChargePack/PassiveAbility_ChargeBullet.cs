using LOR_DiceSystem;

public class PassiveAbility_ChargeBullet : PassiveAbilityBase
{
  public override void BeforeRollDice(BattleDiceBehavior behavior)
  {
    if (behavior.card.card.GetSpec().Ranged == CardRange.Far)
    {
      behavior.card.ApplyDiceAbility(DiceMatch.AllAttackDice, new ChargeBullet());
    }
  }

  private class ChargeBullet : DiceCardAbilityBase
  {
    public override void BeforeRollDice()
    {
      BattleUnitBuf charge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge);
      if (charge != null && charge.stack > 1)
      {
        int stack = charge.stack;
        base.owner.bufListDetail.RemoveBuf(charge);
        if (stack != 2)
          base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, stack - 2);
        base.behavior.ApplyDiceStatBonus(new DiceStatBonus
        {
          power = 2,
          dmg = 3,
        });
      }
    }
  }
}
