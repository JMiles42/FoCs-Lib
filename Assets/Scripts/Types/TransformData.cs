﻿using System;
using UnityEngine;

namespace ForestOfChaosLib.Types
{
	[Serializable]
	public class TransformData
	{
		private static readonly TransformData empty = new TransformData(Vector3.zero, Quaternion.identity, Vector3.one);
		public                  Vector3       Position;
		public                  Quaternion    Rotation;
		public                  Vector3       Scale;

		public static TransformData Empty
		{
			get { return new TransformData(empty); }
		}

		public TransformData()
		{
			Position = Vector3.zero;
			Rotation = Quaternion.identity;
			Scale    = Vector3.one;
		}

		public TransformData(Transform transform)
		{
			Rotation = transform.rotation;
			Scale    = transform.localScale;
			Position = transform.position;
		}

		public TransformData(TransformData transform)
		{
			Rotation = transform.Rotation;
			Scale    = transform.Scale;
			Position = transform.Position;
		}

		public TransformData(Vector3 position)
		{
			Rotation = Quaternion.identity;
			Scale    = Vector3.one;
			Position = position;
		}

		public TransformData(Vector3 position, Quaternion rotation)
		{
			Rotation = rotation;
			Scale    = Vector3.one;
			Position = position;
		}

		public TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Rotation = rotation;
			Scale    = scale;
			Position = position;
		}

		public void SetData(Transform transform)
		{
			Rotation = transform.rotation;
			Scale    = transform.localScale;
			Position = transform.position;
		}

		public void SetData(TransformData transform)
		{
			Rotation = transform.Rotation;
			Scale    = transform.Scale;
			Position = transform.Position;
		}

		public void SetData(Vector3 position)
		{
			Rotation = Quaternion.identity;
			Scale    = Vector3.one;
			Position = position;
		}

		public void SetData(Vector3 position, Quaternion rotation)
		{
			Rotation = rotation;
			Scale    = Vector3.one;
			Position = position;
		}

		public void SetData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Rotation = rotation;
			Scale    = scale;
			Position = position;
		}

		public void UpdateData(Transform transform)
		{
			Rotation = transform.rotation;
			Scale    = transform.localScale;
			Position = transform.position;
		}

		public void UpdateData(TransformData transform)
		{
			Rotation = transform.Rotation;
			Scale    = transform.Scale;
			Position = transform.Position;
		}

		public void UpdateData(Vector3 position)
		{
			Position = position;
		}

		public void UpdateData(Vector3 position, Quaternion rotation)
		{
			Rotation = rotation;
			Position = position;
		}

		public void UpdateData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Rotation = rotation;
			Scale    = scale;
			Position = position;
		}

		public void ApplyData(Transform transform)
		{
			transform.rotation   = Rotation;
			transform.localScale = Scale;
			transform.position   = Position;
		}

		public TransformData Copy()
		{
			return new TransformData(this);
		}

		public static implicit operator TransformData(Transform input)
		{
			return new TransformData(input);
		}

		public static implicit operator TransformData(Component input)
		{
			return new TransformData(input.transform);
		}

		public static implicit operator TransformData(GameObject input)
		{
			return new TransformData(input.transform);
		}

		public static TransformData Create(Transform transform)
		{
			return new TransformData(transform);
		}
	}

	public static class TransformDataExtn
	{
		public static void SetFromTD(this Transform transform, TransformData data)
		{
			data.ApplyData(transform);
		}
	}
}
