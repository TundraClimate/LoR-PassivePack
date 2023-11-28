public class PassiveAbility_ExtraInfFairy : PassiveAbilityBase
{
  public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
  {
    if (curCard.card.GetID().id == 607202)
    {
      curCard.ApplyDiceAbility(DiceMatch.AllAttackDice, new InfFairy());
    }
  }

  private class InfFairy : DiceCardAbilityBase
  {
    public override void OnSucceedAttack(BattleUnitModel target)
    {
      if (!target.IsDead())
        base.ActivateBonusAttackDice();
    }
  }
}
