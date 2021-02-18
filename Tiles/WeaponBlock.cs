using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Tiles

{
    public class WeaponBlock : ModTile
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
            int[] weaponID = { ItemID.WoodenSword, ItemID.Excalibur, ItemID.GoldShortsword, ItemID.CandyCaneSword, ItemID.BeamSword, ModContent.ItemType<Items.Weapons.LuckySword>(), ModContent.ItemType<Items.Weapons.LuckyBow>()};
            int x = Main.rand.Next(weaponID.Length);
            drop = weaponID[x];
            return true;
        }

    }

}