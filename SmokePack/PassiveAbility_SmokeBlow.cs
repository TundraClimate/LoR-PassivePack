using LOR_DiceSystem;

public class PassiveAbility_SmokeBlow : PassiveAbilityBase
{
  public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
  {
    List<DiceBehaviour> dices = curCard.GetOriginalDiceBehaviorList();
    if (dices.FindAll(dice => dice.Type != BehaviourType.Standby).Count == 1)
    {
      BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
      if (smoke != null)
      {
        curCard.ApplyDiceStatBonus(DiceMatch.AllDice, new DiceStatBonus
        {
          dmg = smoke.stack * 2
        });
      }
    }
  }
}
