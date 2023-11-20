public class PassiveAbility_SmokeWar : PassiveAbilityBase
{
  public override void OnRoundStart()
  {
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Decay, 1, base.owner);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Weak, 1, base.owner);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Disarm, 1, base.owner);
  }

  public override void OnWaveStart()
  {
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Decay, 5, base.owner);
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Smoke, 8, base.owner);
  }

  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    BattleUnitModel target = behavior.card.target;
    if (target == null) return;
    if (base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke) != null)
    {
      target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Decay, 1, base.owner);
    }
  }
}
