using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Placeable
{
    public class WeaponBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weapon Luckyblock");
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
            item.createTile = ModContent.TileType<Tiles.WeaponBlock>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumShortsword, 1);
            recipe.AddIngredient(ModContent.ItemType<BaseCraftingBlock>(), 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            ModRecipe recipeGold = new ModRecipe(mod);
            recipeGold.AddIngredient(ItemID.GoldShortsword, 1);
            recipeGold.AddIngredient(ModContent.ItemType<BaseCraftingBlock>(), 1);
            recipeGold.AddTile(TileID.CrystalBall);
            recipeGold.SetResult(this, 5);
            recipeGold.AddRecipe();
        }
    }
}