public class PassiveAbility_SmokeDraw : PassiveAbilityBase
{
  private bool _alreadyUsed = false;

  public override void OnRoundStart()
  {
	this._alreadyUsed = false;
  }

  public override void OnSucceedAttack(BattleDiceBehavior behavior)
  {
	if (behavior.card == null || behavior.card.target == null) return;
	if (this._alreadyUsed) return;
	BattleUnitModel target = behavior.card.target;
	BattleUnitBuf targetSmoke = target.bufListDetail.GetActivatedBuf(KeywordBuf.Smoke);
	if (targetSmoke != null && targetSmoke.stack >= 5)
	{
	  base.owner.allyCardDetail.DrawCards(1);
	  this._alreadyUsed = true;
	}
  }
}
