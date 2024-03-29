﻿using System.Linq;
using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeCountToSellSliderSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCountToSellSliderSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		private GameEntity SellWindow => _contexts.game.GetEntities(GameMatcher.SellWindow).First();

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Slider"))
			            .Do((e) => e.AddView(UI.Windows.Sell.CountToSellSlider.gameObject))
			            .AttachTo(SellWindow)
			            .Do((e) => e.AddProduct(_contexts.game.storage.Value.Trees.First().Product))
			            .Do((e) => e.AddSliderValue(0))
			            .Do((e) => e.AddSliderMaxValue(0));
	}
}