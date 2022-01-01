using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace dfcos.van
{
	[AutoloadEquip(EquipType.Legs)]
	public class dfleg : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("DualFighter Leggings");
			Tooltip.SetDefault("Vanity Item.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
		}
	}
}