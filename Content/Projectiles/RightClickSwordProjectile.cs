
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Content.Projectiles
{
    public class RightClickSwordProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Right Click Sword Projectile");
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.TerraBeam);
            Projectile.Name = "Dong Note";
            AIType = ProjectileID.TerraBeam;
            Projectile.rotation = Projectile.velocity.ToRotation(); // Projectile faces sprite right
			Projectile.spriteDirection = Projectile.direction;
        }


    }
}