﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Code.Global.PlayerContexts.CustomTypes;
using Code.Unity.TEMP;
using Code.Utils.StaticClasses;
using EcoFarmModel;
using Entitas;
using Newtonsoft.Json;
using static Code.Data.StorageJson.JsonUtils;

namespace Code.Global.PlayerContexts.Systems
{
	public sealed class LoadPlayersSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public LoadPlayersSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			Deserialize()
				.Select(ToEntity)
				.First()
				.isCurrentPlayer = true;
		}

		private PlayerEntity ToEntity(Player player)
		{
			var e = _contexts.player.CreateEntity();
			e.isPlayer = true;
			e.AddNickname(player.Nickname);
			e.AddCompletedLevelsCount(player.CompletedLevelsCount);
			e.AddSessionResult(SessionResult.None);
			return e;
		}

		private static IEnumerable<Player> Deserialize()
		{
			var path = Constants.PathToPlayers;
			if (File.Exists(path) == false)
			{
				TempPlayersCreator.CreateEmpty();
			}

			var json = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<Player[]>(json, WithReferences);
		}
	}
}