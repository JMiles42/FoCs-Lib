﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library
//       File: UnityEventsExtensions.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:48 AM
#endregion


using UnityEngine;

namespace ForestOfChaosLibrary.Extensions {
    public static class UnityEventsExtensions {
        public static bool LeftClick(this Event @event) => @event.LeftUp();

        public static bool LeftUp(this Event @event) => (@event.type == EventType.MouseUp) && (@event.button == 0);

        public static bool RightClick(this Event @event) => @event.RightUp();

        public static bool RightUp(this Event @event) => (@event.type == EventType.MouseUp) && (@event.button == 1);

        public static bool LeftDown(this Event @event) => (@event.type == EventType.MouseDown) && (@event.button == 0);

        public static bool RightDown(this Event @event) => (@event.type == EventType.MouseDown) && (@event.button == 1);

        public static bool LeftDrag(this Event @event) => (@event.type == EventType.MouseDrag) && (@event.button == 0);

        public static bool RightDrag(this Event @event) => (@event.type == EventType.MouseDrag) && (@event.button == 1);
    }
}