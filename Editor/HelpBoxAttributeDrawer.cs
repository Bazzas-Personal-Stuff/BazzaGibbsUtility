using UnityEditor;
using UnityEngine;

namespace BazzaGibbs.Utility
{
    [CustomPropertyDrawer(typeof(HelpBoxAttribute))]
    public class HelpBoxAttributeDrawer : DecoratorDrawer
    {
        public override float GetHeight() {
            if (attribute is not HelpBoxAttribute helpBoxAttribute) return base.GetHeight();
            GUIStyle helpBoxStyle = (GUI.skin != null) ? GUI.skin.GetStyle("helpbox") : null;
            if (helpBoxStyle == null) return base.GetHeight();
            return Mathf.Max(40f, helpBoxStyle.CalcHeight(new GUIContent(helpBoxAttribute.message), EditorGUIUtility.currentViewWidth) + 4);
        }
 
        public override void OnGUI(Rect position) {
            if (attribute is not HelpBoxAttribute helpBoxAttribute) return;
            EditorGUI.HelpBox(position, helpBoxAttribute.message, GetMessageType(helpBoxAttribute.messageType));
        }
 
        private static MessageType GetMessageType(HelpBoxMessageType helpBoxMessageType) {
            return helpBoxMessageType switch {
                HelpBoxMessageType.None => MessageType.None,
                HelpBoxMessageType.Info => MessageType.Info,
                HelpBoxMessageType.Warning => MessageType.Warning,
                HelpBoxMessageType.Error => MessageType.Error,
                _ => MessageType.None
            };
        }
    }
}
