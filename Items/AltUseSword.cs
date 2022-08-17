using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class AltUseSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("AltUseSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is mad as.");
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
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
                Item.useStyle = ItemUseStyleID.Stabbing;
                Item.useTime = 20;
                Item.useAnimation = 20;
                Item.damage = 50;
                Item.shoot = ProjectileID.Bee;
            }
            else
            {
                Item.useStyle = ItemUseStyleID.SwingThrow;
                Item.useTime = 40;
                Item.useAnimation = 40;
                Item.damage = 100;
                Item.shoot = ProjectileID.None;
            }
            return base.CanUseItem(player);
        }
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