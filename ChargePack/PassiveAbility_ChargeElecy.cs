public class PassiveAbility_ChargeElecy : PassiveAbilityBase
{
  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    BattleUnitBuf charge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge);
    if (charge != null && charge.stack > 10)
    {
      behavior.card.target.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Paralysis, 1, base.owner);
    }
  }
}
