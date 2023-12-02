public class PassiveAbility_BulletSupply : PassiveAbilityBase
{
  public override void OnRoundEnd()
  {
    base.owner.allyCardDetail.AddNewCard(ThumbBulletClass.GetRandomBulletId(), false);
  }
}
