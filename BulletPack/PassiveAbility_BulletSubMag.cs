public class PassiveAbility_BulletSubMag : PassiveAbilityBase
{
  public override void OnWaveStart()
  {
    for (int i = 0; i < 4; i++)
      base.owner.allyCardDetail.AddNewCard(ThumbBulletClass.GetRandomBulletId(), false);
  }
}
