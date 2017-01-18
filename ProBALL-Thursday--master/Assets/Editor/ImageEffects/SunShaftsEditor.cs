using System;
using UnityEditor;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    [CustomEditor(typeof(SunShafts))]
    class SunShaftsEditor : Editor
    {
        SerializedObject serObj;

        SerializedProperty sunTransform;
        SerializedProperty radialBlurIterations;
        SerializedProperty sunColor;
        SerializedProperty sunThreshold;
        SerializedProperty sunShaftBlurRadius;
        SerializedProperty sunShaftIntensity;
        SerializedProperty useDepthTexture;
        SerializedProperty resolution;
        SerializedProperty screenBlendMode;
        SerializedProperty maxRadius;

        void OnEnable()
        {
            serObj = new SerializedObject(target);

            screenBlendMode = serObj.FindProperty("screenBlendMode");

            sunTransform = serObj.FindProperty("sunTransform");
            sunColor = serObj.FindProperty("sunColor");
            sunThreshold = serObj.FindProperty("sunThreshold");

            sunShaftBlurRadius = serObj.FindProperty("sunShaftBlurRadius");
            radialBlurIterations = serObj.FindProperty("radialBlurIterations");

            sunShaftIntensity = serObj.FindProperty("sunShaftIntensity");

            resolution = serObj.FindProperty("resolution");

            maxRadius = serObj.FindProperty("maxRadius");

            useDepthTexture = serObj.FindProperty("useDepthTexture");
        }


        public override void OnInspectorGUI()
        {
            serObj.Update();

            EditorGUILayout.BeginHorizontal();

          
            EditorGUILayout.EndHorizontal();

            // depth buffer need
            /*
		bool  newVal = useDepthTexture.boolValue;
		if (newVal != oldVal) {
			if (newVal)
				(target as SunShafts).camera.depthTextureMode |= DepthTextureMode.Depth;
			else
				(target as SunShafts).camera.depthTextureMode &= ~DepthTextureMode.Depth;
		}
		*/

            EditorGUILayout.PropertyField(resolution, new GUIContent("Resolution"));
            EditorGUILayout.PropertyField(screenBlendMode, new GUIContent("Blend mode"));

            EditorGUILayout.Separator();

            EditorGUILayout.BeginHorizontal();

        }
    }
}
