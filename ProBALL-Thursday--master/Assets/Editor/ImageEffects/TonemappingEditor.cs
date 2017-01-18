using System;
using UnityEditor;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    [CustomEditor (typeof(Tonemapping))]
    class TonemappingEditor : Editor
    {
        SerializedObject serObj;

        SerializedProperty type;

        // CURVE specific parameter
        SerializedProperty remapCurve;

        SerializedProperty exposureAdjustment;

        // REINHARD specific parameter
        SerializedProperty middleGrey;
        SerializedProperty white;
        SerializedProperty adaptionSpeed;
        SerializedProperty adaptiveTextureSize;

        void OnEnable () {
            serObj = new SerializedObject (target);

            type = serObj.FindProperty ("type");
            remapCurve = serObj.FindProperty ("remapCurve");
            exposureAdjustment = serObj.FindProperty ("exposureAdjustment");
            middleGrey = serObj.FindProperty ("middleGrey");
            white = serObj.FindProperty ("white");
            adaptionSpeed = serObj.FindProperty ("adaptionSpeed");
            adaptiveTextureSize = serObj.FindProperty("adaptiveTextureSize");
        }


        public override void OnInspectorGUI () {
            serObj.Update ();

            GUILayout.Label("Mapping HDR to LDR ranges since 1982", EditorStyles.miniLabel);

       

           
            GUILayout.Label("All following effects will use LDR color buffers", EditorStyles.miniBoldLabel);

            serObj.ApplyModifiedProperties();
        }
    }

    internal class Tonemapping
    {
    }
}
