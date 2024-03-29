﻿using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces.Config;
using static Contexts;

namespace Code.Utils.Extensions.Entitas
{
	public static class DroughtTimerExtensions
	{
		public static GameEntity ResetDroughtTimer(this GameEntity @this)
			=> @this.Do((e) => e.AddDuration(Configuration.Balance.Watering.DroughtDuration));

		private static IConfigurationService Configuration => sharedInstance.GetConfiguration();
	}
}