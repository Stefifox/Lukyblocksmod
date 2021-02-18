using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lukyblocks.Items.Weapons
{
	public class LuckyBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lucky Bow");
			Tooltip.SetDefault("You have a lot of luck!");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 15;
			item.value = Item.buyPrice(platinum: 10);
			item.rare = ItemRarityID.Purple; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 30f; 
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .70f;
		}
	}
}