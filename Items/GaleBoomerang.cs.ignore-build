using Terraria;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class GaleBoomerang : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gale Boomerang");//Sets Item name
            Tooltip.SetDefault("Throwing with left click creates gusts of wind\nThrowing with right click will pull enemies toward you");//Sets tooltip when hovering in inventory
        }

        public override void SetDefaults()
        {
            Item.damage = 36;
            Item.noMelee = true;
            Item.ranged = true;
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.noUseGraphic = true;
            Item.useStyle = 1;
            Item.knockBack = 2;
            Item.value = Item.buyPrice(0, 5, 78, 0);
            Item.rare = 0;
            Item.autoReuse = false;
            Item.shootSpeed = 12f;
            Item.shoot = Mod.ProjectileType("GaleBoomerang");

        }

        public override bool AltFunctionUse(Player player)//You use this to allow the Item to be right clicked
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; i++)//Disables the boomerang from being thrown again until it returns
            {
                if (Main.projectile.active && Main.projectile.owner == Main.myPlayer && Main.projectile.type == Item.shoot)
                {
                    return false;
                }
            }

            if (player.altFunctionUse == 2)//Sets what happens on right click(special ability)
            {
                Item.damage = 36;
                Item.noMelee = true;
                Item.ranged = true;
                Item.width = 20;
                Item.height = 20;
                Item.useTime = 15;
                Item.useAnimation = 15;
                Item.noUseGraphic = true;
                Item.useStyle = 1;
                Item.knockBack = 0;
                throwStyle = 1;
                Item.shoot = mod.ProjectileType("GaleBoomerangProj");

            }
            else //Sets what happens on left click(normal use)
            {
                Item.damage = 36;
                Item.noMelee = true;
                Item.ranged = true;
                Item.width = 20;
                Item.height = 20;
                Item.useTime = 15;
                Item.useAnimation = 15;
                Item.noUseGraphic = true;
                Item.useStyle = 1;
                Item.knockBack = 2;
                throwStyle = 0;
                Item.shoot = mod.ProjectileType("GaleBoomerangProj");

            }

            return true;
        }
    }
}