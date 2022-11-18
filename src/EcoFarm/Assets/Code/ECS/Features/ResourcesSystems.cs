﻿using Code.ECS.Systems.EcoResources;

namespace Code.ECS.Features
{
	public sealed class ResourcesSystems : Feature
	{
		public ResourcesSystems(Contexts contexts)
		{
			Add(new InitializeResourcesSystem(contexts));
		}
	}
}