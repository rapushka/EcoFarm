﻿using System;
using Code.Services.Game.Interfaces.Ui;
using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Services.Game.Implementations.Ui
{
	[Serializable]
	public class UnityUiService : IUiService
	{
		[SerializeField] private ButtonsCollection _buttons;
		[SerializeField] private WindowsCollection _windows;

		public IButtonsCollection Buttons => _buttons;
		public IWindowsCollection Windows => _windows;

		[field: SerializeField] public RectTransform UiRoot     { get; private set; }
		[field: SerializeField] public RectTransform GoalsGroup { get; private set; }
		[field: SerializeField] public GameObject    GoalPrefab { get; private set; }
		[field: SerializeField] public GameObject    CoinsView  { get; private set; }
		[field: SerializeField] public GameObject    AppleView  { get; private set; }
		[field: SerializeField] public GameObject    TimerView  { get; private set; }
		[field: SerializeField] public BuildView     BuildView  { get; private set; }
	}
}