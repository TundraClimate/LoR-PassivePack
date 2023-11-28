public class PassiveAbility_ChargeRipSpace : PassiveAbilityBase
{
  public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
  {
    if (curCard.card.GetID().id == 506001)
    {
      curCard.ApplyDiceAbility(DiceMatch.NextAttackDice, new ChargeRipSpace());
    }
  }

  private class ChargeRipSpace : DiceCardAbilityBase
  {
    private int _count = 0;
    public override void OnSucceedAttack()
    {
      if (this._count < 3)
      {
        base.ActivateBonusAttackDice();
        this._count++;
      }
    }
  }
}
