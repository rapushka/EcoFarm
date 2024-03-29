﻿using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Products.Fruit.Growing
{
	public sealed class CheckGrowthUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;
		private readonly Contexts _contexts;

		public CheckGrowthUpSystem(Contexts contexts)
		{
			_contexts = contexts;
			_entities = contexts.game.GetGroup(AllOf(ProportionalScale, TargetScale));
		}

		private ICommonConfig Constants => _contexts.GetConfiguration().Common;

		public void Execute() => _entities.ForEach(Check);

		private void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity) => entity.OnTargetScaleReached();

		private bool IsGrowth(GameEntity entity)
			=> Mathf.Abs(entity.proportionalScale.Value - entity.targetScale.Value) <= Constants.Tolerance;
	}
}