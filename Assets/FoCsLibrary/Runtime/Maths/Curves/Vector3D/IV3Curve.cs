﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library
//       File: IV3Curve.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:48 AM
#endregion


using System.Collections.Generic;
using UnityEngine;

namespace ForestOfChaosLibrary.Maths.Curves {
    public interface IV3Curve {
        List<Vector3> CurvePositions { get; set; }

        bool IsFixedLength { get; }

        bool UseGlobalSpace { get; set; }

        int Length { get; }

        Vector3 Lerp(float time);
    }
}