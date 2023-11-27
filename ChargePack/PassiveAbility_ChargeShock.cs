public class PassiveAbility_ChargeShock : PassiveAbilityBase
{
  public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
  {
    atkDice.owner.bufListDetail.AddKeywordBufByEtc(KeywordBuf.Paralysis, 1, base.owner);
    base.owner.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.WarpCharge, 2, base.owner);
  }
}
