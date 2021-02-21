﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.DataStructures;

namespace Terraria.ModLoader.Default.Patreon
{
	internal class Sailing_Squid_Head : PatreonItem
	{
		public override string SetName => "Sailing_Squid";
		public override EquipType ItemEquipType => EquipType.Head;

		public override void SetDefaults() {
			base.SetDefaults();
			item.width = 34;
			item.height = 22;
		}
	}

	internal class Sailing_Squid_Body : PatreonItem
	{
		public override string SetName => "Sailing_Squid";
		public override EquipType ItemEquipType => EquipType.Body;

		public override void SetDefaults() {
			base.SetDefaults();
			item.width = 42;
			item.height = 24;
		}
	}

	internal class Sailing_Squid_Legs : PatreonItem
	{
		public override string SetName => "Sailing_Squid";
		public override EquipType ItemEquipType => EquipType.Legs;

		public override void SetDefaults() {
			base.SetDefaults();
			item.width = 22;
			item.height = 18;
		}
	}
	
	internal class Sailing_Squid_Wings : PatreonItem
	{
		public override string SetName => "Sailing_Squid";
		public override EquipType ItemEquipType => EquipType.Wings;

		public override void SetDefaults() {
			base.SetDefaults();
			item.vanity = false;
			item.width = 24;
			item.height = 8;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 150;
		}
	}
}
