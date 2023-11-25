public class PassiveAbility_ChargeHeal : PassiveAbilityBase
{
  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    if (base.owner.hp < base.owner.MaxHp)
    {
      BattleUnitBuf charge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge);
      if (charge != null)
      {
        int stack = charge.stack;
        base.owner.RecoverHP(5);
        base.owner.bufListDetail.RemoveBuf(charge);
        if (stack > 1)
        {
          base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, stack - 1);
        }
      }
    }
  }
}
