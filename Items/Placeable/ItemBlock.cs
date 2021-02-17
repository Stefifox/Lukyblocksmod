using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Placeable
{
    public class ItemBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Item Lukyblock");
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
            item.createTile = mod.TileType("ItemBlock");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenSword, 1);
            recipe.AddIngredient(ModContent.ItemType<BaseCraftingBlock>(), 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}