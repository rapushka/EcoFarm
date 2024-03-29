﻿using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Goals
{
	public sealed class CheckGoalsByProductSystem : ReactiveSystem<GameEntity>
	{
		public CheckGoalsByProductSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(CurrentQuantity);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Mark, @if: IsCompleted);

		private static bool IsCompleted(GameEntity goal)
			=> goal.currentQuantity.Value >= goal.goal.Value.TargetQuantity;

		private static void Mark(GameEntity goal) => goal.isGoalCompleted = true;
	}
}