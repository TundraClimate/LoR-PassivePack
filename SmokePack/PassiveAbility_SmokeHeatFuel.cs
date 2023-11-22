public class PassiveAbility_SmokeHeatFuel : PassiveAbilityBase
{
  public override void OnRoundEnd()
  {
    BattleUnitBuf smoke = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
    if (smoke != null)
    {
      base.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Burn, smoke.stack, base.owner);
      base.owner.cardSlotDetail.RecoverPlayPoint(smoke.stack / 2);
      base.owner.bufListDetail.RemoveBuf(smoke);
    }
  }
}
