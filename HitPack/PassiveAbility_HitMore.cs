using LOR_DiceSystem;

public class PassiveAbility_HitMore : PassiveAbilityBase
{
  public override void BeforeRollDice(BattleDiceBehavior behavior)
  {
    if (behavior.Detail == BehaviourDetail.Hit)
    {
      behavior.ApplyDiceStatBonus(new DiceStatBonus
      {
        power = 3
      });
    }
    if (behavior.Detail == BehaviourDetail.Guard || behavior.Detail == BehaviourDetail.Evasion)
    {
      behavior.ApplyDiceStatBonus(new DiceStatBonus
      {
        power = -2
      });
    }
  }
}
