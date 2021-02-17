using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Placeable
{
    public class WeaponBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weapon Lukyblock");
            Tooltip.SetDefault("Broke me!");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("WeaponBlock");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Woodem, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }
    }
}