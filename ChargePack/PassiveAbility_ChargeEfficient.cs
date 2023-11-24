public class PassiveAbility_ChargeEfficient : PassiveAbilityBase
{
  public override void OnGainChargeStack()
  {
    base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, 1, base.owner);
  }
}
