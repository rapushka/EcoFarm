﻿using System.Collections.Generic;
using Entitas;
using static Code.Global.PlayerContexts.CustomTypes.SessionResult;
using static GameMatcher;

namespace Code.ECS.Systems.Level
{
	public sealed class GameOverSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public GameOverSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(DurationUp, LevelTimer));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> _) 
			=> _contexts.player.currentPlayerEntity.ReplaceSessionResult(Defeat);
	}
}