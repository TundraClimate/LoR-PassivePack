public class PassiveAbility_ChargeBattery : PassiveAbilityBase
{
  public override void OnWaveStart()
  {
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.WarpCharge, 6, base.owner);
  }
}
