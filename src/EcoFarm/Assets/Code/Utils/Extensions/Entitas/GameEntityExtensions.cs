﻿using UnityEngine;

namespace Code.Utils.Extensions.Entitas
{
	public static class GameEntityExtensions
	{
		public static Vector2 GetActualSpawnPosition(this GameEntity @this)
			=> @this.hasSpawnPosition ? @this.spawnPosition.Value
				: @this.hasPosition ? @this.position.Value
				: Vector2.zero;

		public static void PerformRequiredView(this GameEntity @this, GameObject gameObject)
		{
			@this.AddView(gameObject);
			@this.RemoveRequireView();
		}

		public static Vector3 GetActualPosition(this GameEntity @this)
			=> @this.hasPosition ? @this.position.Value
				: @this.hasView ? @this.view.Value.transform.position
				: Vector3.zero;

		public static void IncreaseProportionalScale(this GameEntity @this, float value) 
			=> @this.ReplaceProportionalScale(@this.proportionalScale.Value + value);
	}
}