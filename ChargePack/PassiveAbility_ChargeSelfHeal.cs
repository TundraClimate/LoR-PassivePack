public class PassiveAbility_ChargeSelfHeal : PassiveAbilityBase
{
  public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
  {
    BattleUnitBuf charge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge);
    if (charge != null)
    {
        int stack = charge.stack;
        base.owner.RecoverHP(7);
        base.owner.bufListDetail.RemoveBuf(charge);
        if (stack > 1)
        {
          base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, stack - 1);
        }
    }
  }
}
