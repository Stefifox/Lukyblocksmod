using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Tiles

{
    public class BadBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            AddMapEntry(new Color(200, 200, 200));
        }

        public override bool CanKillTile(int i, int j, ref bool blockDamaged)
        {
            return Main.hardMode;
        }

        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {

            int[] NPCSPawn = { NPCID.KingSlime, NPCID.EyeofCthulhu, NPCID.FemaleZombie, NPCID.SlimedZombie, NPCID.TheDestroyer, NPCID.SkeletronPrime};
            int x = Main.rand.Next(NPCSPawn.Length);
            NPC.SpawnOnPlayer(i, NPCSPawn[x]);
            Main.PlaySound(SoundID.Roar, i, 0);
        }

    }

}