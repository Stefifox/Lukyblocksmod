using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Placeable
{
    public class BadBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Luckyblock");
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
            item.createTile = ModContent.TileType<Tiles.BadBlock>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.BadBaseCraftingBlock>());
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}