public class PassiveAbility_SmokeDmgBufAndBind : PassiveAbilityBase
{
  private int _smokeCount = 0;

  public override void OnRoundStart()
  {
    this._smokeCount = 0;
    BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
    if (smoke != null)
    {
      base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Binding, smoke.stack, base.owner);
      this._smokeCount = smoke.stack;
    }
  }

  public override void BeforeGiveDamage(BattleDiceBehavior behavior)
  {
    behavior.ApplyDiceStatBonus(new DiceStatBonus
    {
      breakDmg = this._smokeCount
    });
  }
}
