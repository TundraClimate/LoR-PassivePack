public class PassiveAbility_BulletMorePower : PassiveAbilityBase
{
  public override void BeforeRollDice(BattleDiceBehavior behavior)
  {
    if (ThumbBulletClass.IsBulletId(behavior.card.card.GetID()))
    {
      behavior.card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
      {
        power = 8,
      });
    }
  }
}
