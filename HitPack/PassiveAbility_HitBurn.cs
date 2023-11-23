using LOR_DiceSystem;

public class PassiveAbility_HitBurn : PassiveAbilityBase
{
  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    if (behavior.Detail == BehaviourDetail.Hit)
    {
      BattleUnitModel target = behavior.card.target;
      if (target != null)
        target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Burn, 1, base.owner);
    }
  }
}
