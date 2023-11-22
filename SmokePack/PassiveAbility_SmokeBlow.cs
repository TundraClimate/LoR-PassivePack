using LOR_DiceSystem;

public class PassiveAbility_SmokeBlow : PassiveAbilityBase
{
  public override void BeforeGiveDamage(BattleDiceBehavior behavior)
  {
    List<DiceBehaviour> dices = behavior.card.GetOriginalDiceBehaviorList();
    if (dices.FindAll(dice => dice.Type != BehaviourType.Standby).Count == 1)
    {
      BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
      if (smoke != null)
      {
        behavior.card.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
        {
          dmg = smoke.stack * 2
        });
      }
    }
  }
}
