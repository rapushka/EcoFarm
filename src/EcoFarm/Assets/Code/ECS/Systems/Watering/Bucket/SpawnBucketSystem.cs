﻿using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Code.Utils.StaticClasses;
using Entitas;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBucketSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Bucket"))
			            // .Do((e) => e.AddRequireView(Constants.ResourcePath.Bucket))
			            // .Do((e) => e.AddPosition(SpawnPointsService.Bucket))
			            ;
	}
}