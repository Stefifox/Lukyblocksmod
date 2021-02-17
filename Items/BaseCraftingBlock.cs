using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Lukyblocks.Items
{
    public class BaseCraftingBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Base Block");
            Tooltip.SetDefault("This block enable you to craft Lukyblocks");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}