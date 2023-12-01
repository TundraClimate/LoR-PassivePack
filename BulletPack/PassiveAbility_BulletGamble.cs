using LOR_DiceSystem;

public class PassiveAbility_BulletGamble : PassiveAbilityBase
{
  public override void OnWinParrying(BattleDiceBehavior behavior)
  {
    if (behavior.card.card.GetSpec().Ranged == CardRange.Far)
    {
      base.owner.breakDetail.RecoverBreak(7);
    }
  }
  
  public override void OnLoseParrying(BattleDiceBehavior behavior)
  {
    if (behavior.card.card.GetSpec().Ranged == CardRange.Far)
    {
      base.owner.TakeBreakDamage(5, DamageType.Passive);
    }
  }
}
