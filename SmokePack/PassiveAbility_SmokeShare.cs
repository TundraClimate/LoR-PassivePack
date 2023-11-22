public class PassiveAbility_SmokeShare : PassiveAbilityBase
{
  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    if (behavior.card == null || behavior.card.target == null) return;
    BattleUnitModel target = behavior.card.target;
    target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, 1, base.owner);
  }
}
