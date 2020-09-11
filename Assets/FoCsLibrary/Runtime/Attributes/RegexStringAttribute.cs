#region � Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library
//       File: RegexStringAttribute.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:02 AM
#endregion


using UnityEngine;

namespace ForestOfChaosLibrary.Attributes {
    public class RegexStringAttribute: PropertyAttribute {
        public readonly string helpMessage;
        public readonly string pattern;

        public RegexStringAttribute(string _pattern, string _helpMessage) {
            pattern     = _pattern;
            helpMessage = _helpMessage;
        }
    }
}