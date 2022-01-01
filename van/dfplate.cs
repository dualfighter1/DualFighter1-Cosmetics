using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace dfcos.van
{
	[AutoloadEquip(EquipType.Body)]
	public class dfplate : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("DualFighter Armour");
			Tooltip.SetDefault("Vanity Item.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
		}
	}
}