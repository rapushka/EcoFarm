﻿namespace Code.Services.Game.Interfaces.Config.BalanceConfigs
{
	public interface IFactoryConfig
	{
		float WorkingDuration           { get; }
		float SendProductToFactoryDelay { get; }
		float RoadToFactoryDuration     { get; }
	}
}