public class PassiveAbility_SmokeBody : PassiveAbilityBase
{
  public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
  {
    if (atkDice != null && !atkDice.owner.IsDead())
    {
      BattleUnitModel target = atkDice.owner;
      target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, 1);
    }
  }
}
