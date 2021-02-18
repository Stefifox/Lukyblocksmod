using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Lukyblocks.Items
{
    public class BadBaseCraftingBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bad Base Block");
            Tooltip.SetDefault("This block enable you to craft Luckyblocks");
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
            recipe.AddIngredient(ModContent.ItemType<Items.BaseCraftingBlock>());
            recipe.AddIngredient(ItemID.BlackLens);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}