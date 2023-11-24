public class PassiveAbility_ChargeLightning : PassiveAbilityBase
{
  public override void OnRoundStartAfter()
  {
    ConvertParalysis();
  }

  public override void OnStartBattle()
  {
    ConvertParalysis();
  }

  private void ConvertParalysis()
  {
    BattleUnitBuf para = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.Paralysis);
    if (para != null)
    {
      int stack = para.stack;
      base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, stack, base.owner);
      base.owner.bufListDetail.RemoveBuf(para);
    }
  }
}
