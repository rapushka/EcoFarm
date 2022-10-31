﻿using static Code.Utils.StaticClasses.Constants.Temp;

namespace Code.Utils.Extensions.Entitas
{
	public static class InventoryExtensions
	{
		public static void CreateInventoryItem(this GameContext @this, string name, int count)
			=> @this.CreateEntity()
			        .Do((e) => e.AddDebugName($"Item: {name} ({count})"))
			        .Do((e) => e.AddFruitTypeId(AppleID))
			        .Do((e) => e.AddInventoryItem((name, count)))
			        .Do((e) => e.AddAttachedTo(@this.inventoryEntity.attachTarget));
	}
}