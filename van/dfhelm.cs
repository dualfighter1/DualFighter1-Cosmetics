using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace dfcos.van
{
	[AutoloadEquip(EquipType.Head)]
	public class dfhelm : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("DualFighter Helmet");
			Tooltip.SetDefault("Vanity Item.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
		}
	}
}