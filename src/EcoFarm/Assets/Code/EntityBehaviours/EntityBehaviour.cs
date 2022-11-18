﻿using System.Collections;
using UnityEngine;

namespace Code.EntityBehaviours
{
	public abstract class EntityBehaviour : MonoBehaviour
	{
		protected GameContext Context => Contexts.sharedInstance.game;
		private void Start() => StartCoroutine(InitializationLoop());

		private IEnumerator InitializationLoop()
		{
			yield return new WaitUntil(ReadyForInitialization);
			Initialize();
		}

		protected abstract bool ReadyForInitialization();

		protected abstract void Initialize();
	}
}