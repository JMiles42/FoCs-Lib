﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: RectHorizontalScope.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:03 AM
#endregion


using ForestOfChaosLibrary.Extensions;
using ForestOfChaosLibrary.Utilities;
using UnityEngine;

namespace ForestOfChaosLibrary.Editor.Utilities {
    public sealed class RectHorizontalScope: RectLayoutScope {
        public RectHorizontalScope(int count, Rect rect): base(count, rect) { }

        protected override Rect InitNextRect() {
            var lRect = Rect;
            lRect.width = lRect.width / Count;

            return lRect;
        }

        protected override void DoNextRect() {
            var nexRect = NextRect;
            nexRect.x += nexRect.width;
            NextRect  =  nexRect;
            ++CurrentIndex;
        }

        protected override Rect DoGetNextAmount(int amount, Rect retVal) {
            retVal = retVal.Edit(RectEdit.SetWidth(retVal.width * amount));

            return retVal;
        }
    }
}