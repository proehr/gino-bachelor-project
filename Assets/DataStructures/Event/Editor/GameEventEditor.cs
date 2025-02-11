﻿// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEditor;
using UnityEngine;

namespace DataStructures.Event.Editor
{
    [CustomEditor(typeof(GameEvent_SO), editorForChildClasses: true)]
    public class GameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent_SO e = target as GameEvent_SO;
            if (GUILayout.Button("Raise"))
            {
                e.Raise();
            }
        }
    }
}