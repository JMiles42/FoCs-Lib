﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library
//       File: UnityTriggerTimes.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using System;

namespace ForestOfChaos.Unity.Utilities.Enums {
    [Flags]
    public enum UnityTriggerTimes {
        Start    = 1 << 0,
        OnEnable = 1 << 1,
        Awake    = 1 << 2,
        None     = 1 << 3
    }
}