﻿using Code.ECS.Components.ComplexComponentTypes;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners.UI
{
	public class ProgressBarView : BaseViewListener, IProgressBarListener
	{
		[SerializeField] private Image _mask;

		protected override void AddListener(GameEntity entity) => entity.AddProgressBarListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasProgressBar;

		protected override void UpdateValue(GameEntity entity) => OnProgressBar(entity, entity.progressBar.Value);

		public void OnProgressBar(GameEntity entity, ProgressBarValues value)
			=> _mask.fillAmount = value.Current / value.Max;
	}
}