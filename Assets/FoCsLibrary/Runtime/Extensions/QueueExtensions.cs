﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library
//       File: QueueExtensions.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using System.Collections.Generic;

namespace ForestOfChaos.Unity.Extensions {
    public static class QueueExtensions {
        public static T GetNextItemAndReAddItToTheEnd<T>(this Queue<T> queue) {
            //Get first
            var item = queue.Dequeue();
            //Re add
            queue.Enqueue(item);

            return item;
        }
    }
}