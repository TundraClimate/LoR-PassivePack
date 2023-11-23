using LOR_DiceSystem;

public class PassiveAbility_HitScar : PassiveAbilityBase
{
  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    if (behavior.Detail == BehaviourDetail.Hit)
    {
      BattleUnitModel target = behavior.card.target;
      if (target != null)
      {
        target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Bleeding, 1, base.owner);
        BattleUnitBuf bleed = target.bufListDetail.GetActivatedBuf(KeywordBuf.Bleeding);
        if (bleed != null && bleed.stack >= 8)
        {
          target.TakeDamage(3, DamageType.Passive, base.owner);
        }
      }
    }
  }
}
