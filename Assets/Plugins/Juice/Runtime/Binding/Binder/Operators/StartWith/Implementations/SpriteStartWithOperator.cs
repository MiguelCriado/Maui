﻿using UnityEngine;

namespace Juice
{
	public class SpriteStartWithOperator : StartWithOperator<Sprite>
	{
		protected override ConstantBindingInfo<Sprite> InitialValue => initialValue;

		[SerializeField] private SpriteConstantBindingInfo initialValue = new SpriteConstantBindingInfo();
	}
}