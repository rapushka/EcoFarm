﻿using System.IO;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;
using static Code.Data.StorageJson.JsonUtils;
using static Code.Utils.StaticClasses.Constants;
using Tree = EcoFarmDataModule.Tree;

namespace Code.Unity.Editor.Data
{
	public static class TempDataCreator
	{
		public static void Create() => Serialization(NewStorage());

		private static Storage NewStorage()
		{
			var apple = new Product
			{
				Title = "Apple",
				Description = "Is a sweet, edible fruit produced by an apple tree.",
				Price = 2,
			};

			var coin = new Product
			{
				Title = CoinItemName,
				Description = "Is a medium of exchange, a unit of account, and a store of value.",
				Price = 1,
			};

			return new Storage
			{
				Products = new[]
				{
					coin,
					apple,
				},
				
				Levels = new[]
				{
					new Level
					{
						Order = 1,
						TreesCount = 5,
						SecondsForLevel = 60,
						Goals = new Goal[]
						{
							new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 5 },
							new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 15 },
						},
					},
					new Level
					{
						Order = 2,
						TreesCount = 9,
						SecondsForLevel = 100,
						Goals = new Goal[]
						{
							new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 10 },
						},
					},
				},
				Trees = new[]
				{
					new Tree
					{
						Title = "Apple Tree",
						Description = "Giving apples",
						Product = apple,
					},
				},
			};
		}

		private static void Serialization(Storage storage)
		{
			File.WriteAllText(PathToStorage, SerializeObject(storage));
			Debug.Log($"File created on {PathToStorage}");
		}

		private static string SerializeObject(Storage storage)
			=> JsonConvert.SerializeObject(storage, Formatting.Indented, WithReferences);
	}
}