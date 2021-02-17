using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Placeable
{
    public class allBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lukyblock");
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
            item.createTile = ModContent.TileType<Tiles.allBlock>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<WeaponBlock>());
            recipe.AddIngredient(ModContent.ItemType<ItemBlock>());
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            ModRecipe recipea = new ModRecipe(mod);
            recipea.AddIngredient(ModContent.ItemType<BaseCraftingBlock>(), 2);
            recipea.AddIngredient(ItemID.CrystalShard, 50);
            recipea.AddIngredient(ItemID.WoodenSword);
            recipea.AddTile(TileID.CrystalBall);
            recipea.SetResult(this, 1);
            recipea.AddRecipe();

        }
    }
}