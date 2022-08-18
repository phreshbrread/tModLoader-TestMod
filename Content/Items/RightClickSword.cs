using TestMod.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Content.Items
{
    public class RightClickSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("RightClickSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is mad as.");
        }

        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override bool AltFunctionUse(Player player) // You use this to allow the Item to be right clicked
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2) // Set what happens on right click
            {
                Item.useStyle = ItemUseStyleID.Thrust;
                Item.useTime = 10;
                Item.useAnimation = 20;
                Item.damage = 80;
                Item.shoot = ModContent.ProjectileType<RightClickSwordProjectile>();
                Item.autoReuse = true;
            }
            else
            {
                Item.useStyle = ItemUseStyleID.Swing;
                Item.useTime = 40;
                Item.useAnimation = 40;
                Item.shoot = ProjectileID.None;
            }
            return base.CanUseItem(player);
        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}