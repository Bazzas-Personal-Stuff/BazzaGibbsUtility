using UnityEngine;

// Attribute for adding help boxes in the inspector without custom editors or PropertyDrawers.
//
// Credit to TonyLi, 2017/04/01
// https://forum.unity.com/threads/helpattribute-allows-you-to-use-helpbox-in-the-unity-inspector-window.462768/


namespace BazzaGibbs.Utility
{
    public enum HelpBoxMessageType {
        None,
        Info,
        Warning,
        Error
    }
    
    public class HelpBoxAttribute : PropertyAttribute {
        public string message;
        public HelpBoxMessageType messageType;

        public HelpBoxAttribute(string message, HelpBoxMessageType messageType = HelpBoxMessageType.Info) {
            this.message = message;
            this.messageType = messageType;
        }
    }
}
