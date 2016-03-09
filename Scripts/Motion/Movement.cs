﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace UrMotion
{
	public static class Movement
	{
		public static IEnumerator<float> Sin(IEnumerator<float> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector2> Sin(IEnumerator<Vector2> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector3> Sin(IEnumerator<Vector3> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		public static IEnumerator<Vector4> Sin(IEnumerator<Vector4> radius, float freq, float fps)
		{
			return Move(Source.Sin(radius, freq, fps));
		}

		static IEnumerator<float> Move(IEnumerator<float> movement)
		{
			var v = default(float);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector2> Move(IEnumerator<Vector2> movement)
		{
			var v = default(Vector2);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector3> Move(IEnumerator<Vector3> movement)
		{
			var v = default(Vector3);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}

		static IEnumerator<Vector4> Move(IEnumerator<Vector4> movement)
		{
			var v = default(Vector4);
			while (movement.MoveNext()) {
				var c = movement.Current;
				yield return c - v;
				v = c;
			}
		}
	}
}