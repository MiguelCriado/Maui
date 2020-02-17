﻿using System;
using UnityEngine;

namespace Muui
{
	[Serializable]
	public class ObservableVariable<T> : IObservableVariable<T>
	{
		public event ObservableVariableDelegate<T> OnChange;

		public bool HasValue { get; protected set; }

		public T Value
		{
			get { return value;}

			set
			{
				if (value.Equals(this.value) == false)
				{
					SetValue(value);
					OnChange?.Invoke(value);
				}
			}
		}

		[SerializeField] private T value;

		public ObservableVariable() : this(default)
		{

		}

		public ObservableVariable(T initialValue)
		{
			SetValue(initialValue);
		}

		private void SetValue(T newValue)
		{
			value = newValue;
			HasValue = true;
		}
	}
}