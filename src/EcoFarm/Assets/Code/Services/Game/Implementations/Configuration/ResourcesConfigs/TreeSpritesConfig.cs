﻿using System;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
{
	[Serializable]
	public class TreeSpritesConfig : ITreeSpritesConfig
	{
		[field: SerializeField] public Sprite Dry    { get; private set; }
		[field: SerializeField] public Sprite Normal { get; private set; }
		[field: SerializeField] public Sprite Rotten { get; private set; }
	}
}