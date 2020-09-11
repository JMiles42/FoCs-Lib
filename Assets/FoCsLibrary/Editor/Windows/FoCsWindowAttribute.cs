﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: FoCsWindowAttribute.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:03 AM
#endregion


using System;

namespace ForestOfChaosLibrary.Editor {
    /// <summary>
    ///     This Attribute is used for Windows that can be opened via the FoCs Control Panel
    ///     Requires a method
    ///     "static Init()"
    ///     "override void OnGUI()"
    /// </summary>
    public class FoCsWindowAttribute: Attribute { }
}