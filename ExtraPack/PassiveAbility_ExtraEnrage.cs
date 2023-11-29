public class PassiveAbility_ExtraInfEnrage : PassiveAbilityBase
{
  public override void OnRoundStart()
  {
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Strength, 999);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Endurance, 999);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Protection, 999);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.BreakProtection, 999);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Quickness, 999);
  }
}
