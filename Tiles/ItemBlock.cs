using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Tiles

{
    public class ItemBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            AddMapEntry(new Color(200, 200, 200));
        }

        public override bool Drop(int i, int j)
        {
            int[] items = { ItemID.CrystalShard, ModContent.ItemType<Items.Placeable.ItemBlock>(), ModContent.ItemType<Items.Placeable.WeaponBlock>(), ModContent.ItemType<Items.Placeable.BadBlock>(), ItemID.Blinkroot, ItemID.Daybloom, ItemID.Gel,
            ItemID.UnluckyYarn, ItemID.Fireblossom, ItemID.BrokenHeroSword, ItemID.Waterleaf, ItemID.Keg, ItemID.Kimono, ModContent.ItemType<Items.BadBaseCraftingBlock>(), ItemID.Star, ItemID.Heart, ItemID.Tiara, ItemID.Flare, ItemID.Torch, ItemID.Umbrella,
            ModContent.ItemType<Items.Armor.LuckyHat>()};
            int x = Main.rand.Next(items.Length);
            drop = items[x];
            return true;
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }

}