﻿using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.UI
{
	public sealed class PrepareSellWindowSystem : ReactiveSystem<GameEntity>
	{
		public PrepareSellWindowSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PreparationInProcess, SellWindow));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Prepare);

		private static void Prepare(GameEntity window)
			=> window.Do((e) => e.isPreparationInProcess = false)
			         .Do((e) => e.isPrepared = true);
	}
}