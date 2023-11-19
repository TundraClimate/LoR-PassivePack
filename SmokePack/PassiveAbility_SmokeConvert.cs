public class PassiveAbility_SmokeConvert : PassiveAbilityBase
{
  public override void OnRoundStart()
  {
    BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
    if (smoke != null)
    {
      int divided = (smoke.stack + 1) / 2;
      base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, divided, base.owner);
      base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Endurance, divided, base.owner);
      base.owner.bufListDetail.RemoveBuf(base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke));
    }
  }
}
