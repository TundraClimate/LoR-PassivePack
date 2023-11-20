public class PassiveAbility_SmokeSteam : PassiveAbilityBase
{
  public override void OnRoundStart()
  {
    BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
    int quick = 0;
    if (smoke == null) return;
    else quick += 2; 
    if (smoke.stack >= 6)
      quick += 2;
    base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Quickness, quick, base.owner);
  }
}
