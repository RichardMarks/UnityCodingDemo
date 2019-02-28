using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(GenericStats))]
public class GenericStatsPropertyDrawer : PropertyDrawer
{
    private int atk;
    private int def;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        // position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        float lineHeight = position.height / 2.0f;
        Rect attackRect = new Rect(position.x, position.y, position.width, lineHeight);
        Rect defenseRect = new Rect(position.x, lineHeight + position.y, position.width, lineHeight);

        SerializedProperty attackProperty = property.FindPropertyRelative("attack");
        SerializedProperty defenseProperty = property.FindPropertyRelative("defense");

        atk = attackProperty.intValue;
        def = defenseProperty.intValue;
        atk = EditorGUI.IntSlider(attackRect, "Attack Strength", atk, 1, 255);
        def = EditorGUI.IntSlider(defenseRect, "Defense Strength", def, 1, 255);

        attackProperty.intValue = atk;
        defenseProperty.intValue = def;

        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) * 2.0f;
    }
}
