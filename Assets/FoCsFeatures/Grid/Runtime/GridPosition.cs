﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Features.Grid
//       File: GridPosition.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:11 PM
#endregion

using System;
using ForestOfChaos.Unity.Types;
using UnityEngine;

namespace ForestOfChaos.Unity.Features.Grid {
    [Serializable]
    public struct GridPosition {
        public Vector2I Position;

        public int X {
            get => Position.x;
            set => Position.x = value;
        }

        public int Y {
            get => Position.y;
            set => Position.y = value;
        }

        public GridPosition(Vector2I position) => Position = position;

        public GridPosition(GridPosition position): this(position.Position) { }

        public GridPosition(Vector3 position): this(position.GetGridPosition()) { }

        public GridPosition(int x, int y): this(new Vector2I(x, y)) { }

        public Vector3 WorldPosition => Position.FromX_Y2Z();

        public Vector2 ToVector2() => Position;

        public static GridPosition Zero { get; } = new GridPosition(Vector2I.Zero);

        public static GridPosition One { get; } = new GridPosition(Vector2I.One);

        public static GridPosition MinInt { get; } = new GridPosition(Vector2I.MinInt);

        public static GridPosition MaxInt { get; } = new GridPosition(Vector2I.MaxInt);

        public static implicit operator GridPosition(Vector3 input) => new GridPosition(input);

        public static implicit operator GridPosition(Vector2I input) => new GridPosition(input);

        public static implicit operator Vector2I(GridPosition input) => input.Position;

        public static implicit operator Vector3(GridPosition input) => input.Position.FromX_Y2Z();

        public override bool Equals(object obj) {
            if (obj is GridPosition)
                return base.Equals((GridPosition)obj);

            return false;
        }

        public bool Equals(GridPosition obj) => (obj.X == X) && (obj.Y == Y);

        public override int GetHashCode() => Position.GetHashCode();

        public static bool operator ==(GridPosition left, GridPosition right) => left.Equals(right);

        public static bool operator !=(GridPosition left, GridPosition right) => !left.Equals(right);

        public static GridPosition operator -(GridPosition left, GridPosition right) => new GridPosition(left.Position - right.Position);

        public static GridPosition operator +(GridPosition left, GridPosition right) => new GridPosition(left.Position + right.Position);

        public static GridPosition operator -(GridPosition left, Vector2I right) => new GridPosition(left.Position - right);

        public static GridPosition operator +(GridPosition left, Vector2I right) => new GridPosition(left.Position + -right);

        public override string ToString() => $"Grid (X:{X} Y:{Y})";

        public GridPosition Left {
            get {
                var rv = new GridPosition(this);
                rv.X -= 1;

                return rv;
            }
        }

        public GridPosition Right {
            get {
                var rv = new GridPosition(this);
                rv.X += 1;

                return rv;
            }
        }

        public GridPosition Down {
            get {
                var rv = new GridPosition(this);
                rv.Y -= 1;

                return rv;
            }
        }

        public GridPosition Up {
            get {
                var rv = new GridPosition(this);
                rv.Y += 1;

                return rv;
            }
        }
    }
}