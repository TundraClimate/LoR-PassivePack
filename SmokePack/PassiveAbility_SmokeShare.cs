public class PassiveAbility_SmokeShare : PassiveAbilityBase
{
  private IDictionary<BattleUnitModel, int> _alreadySharedCount = new Dictionary<BattleUnitModel, int>();

  public override void OnRoundStart()
  {
    this._alreadySharedCount.Clear();
  }

  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
    if (behavior.card == null || behavior.card.target == null) return;
    BattleUnitModel target = behavior.card.target;
    if (this._alreadySharedCount.ContainsKey(target))
    {
      this._alreadySharedCount[target] += 1;
    }
    else
    {
      this._alreadySharedCount.Add(target, 1);
    }
    if (this._alreadySharedCount[target] > 3) return;
    target.bufListDetail.AddKeywordBufThisRoundByEtc(KeywordBuf.Smoke, 1, target);
  }
}
