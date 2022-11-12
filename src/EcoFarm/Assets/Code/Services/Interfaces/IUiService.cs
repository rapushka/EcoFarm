﻿using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IUiService
	{
		GameObject         CoinsView  { get; }
		GameObject         AppleView  { get; }
		GameObject         GoalPrefab { get; }
		IWindowsCollection Windows    { get; }
		IButtonsCollection Buttons    { get; }
	}
}