using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Tiles

{
    public class allBlock : ModTile
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
            int[] items = { ItemID.CrystalShard, ModContent.ItemType<Items.Placeable.ItemBlock>(), ModContent.ItemType<Items.Placeable.WeaponBlock>(), ItemID.WoodenSword, ItemID.Excalibur, ItemID.GoldShortsword, ItemID.CandyCaneSword, ItemID.BeamSword};
            int x = Main.rand.Next(items.Length);
            drop = items[x];
            return true;
        }

    }

}