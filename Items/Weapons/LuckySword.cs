using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Weapons
{
	public class LuckySword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lucky Sword");
			Tooltip.SetDefault("You have a lot of luck!");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.knockBack = 20;
			item.value = Item.buyPrice(platinum: 10);
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1; 
			item.autoReuse = true; 
			item.crit = 76;
			item.expert = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Ichor, 10 * 60);
			player.AddBuff(BuffID.HeartLamp, 5 * 60);
		}

	}
}