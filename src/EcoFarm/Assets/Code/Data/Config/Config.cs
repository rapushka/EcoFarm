﻿using System;

namespace Code.Data.Config
{
	[Serializable]
	public class Config
	{
		public int TreesCount;

		public Config(int treesCount)
		{
			TreesCount = treesCount;
		}

		public static Config Default => new(0);
	}
}