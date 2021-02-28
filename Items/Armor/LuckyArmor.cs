using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    class LuckyArmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Lucky Armor");
            Tooltip.SetDefault("Protect you");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Purple;
            item.defense = 45;
            item.expert = true;
            item.expertOnly = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.AddBuff(BuffID.HeartLamp, 100 * 60);
            player.statManaMax2 += 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.BaseCraftingBlock>(), 45);
            recipe.AddIngredient(ModContent.ItemType<Items.BadBaseCraftingBlock>(), 45);
            recipe.AddIngredient(ModContent.ItemType<Items.Placeable.ItemBlock>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Placeable.WeaponBlock>(), 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
