public class PassiveAbility_SmokeSupply : PassiveAbilityBase
{
  public override void OnRoundStart()
  {
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Smoke, 1, base.owner);
  }
}
