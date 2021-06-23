/*
Copyright (c) 2020 Omar Duarte
Unauthorized copying of this file, via any medium is strictly prohibited.
Writen by Omar Duarte, 2020.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PluginMaster
{
    public class PlayModeSave : EditorWindow
    {
        #region CONTEXT
        const string TOOL_NAME = "Play Mode Save";
        [MenuItem("CONTEXT/Transform/Save Play Mode Changes", true, 2000)]
        private static bool ValidateSaveMenu(MenuCommand command) => PrefabUtility.GetPrefabAssetType(command.context) == PrefabAssetType.NotAPrefab && Application.IsPlaying(command.context);

        [MenuItem("CONTEXT/Transform/Save Play Mode Changes", false, 2000)]
        private static void SaveMenu(MenuCommand command) => Add(command.context as Transform);

        [MenuItem("CONTEXT/Transform/Apply Play Mode Changes", true, 2001)]
        private static bool ValidateApplyMenu(MenuCommand command) => !Application.isPlaying && _toApply.Contains((command.context as Transform).gameObject.GetInstanceID());

        [MenuItem("CONTEXT/Transform/Apply Play Mode Changes", false, 2001)]
        private static void ApplyMenu(MenuCommand command) => Apply((command.context as Transform).gameObject.GetInstanceID());
        #endregion

        #region WINDOW
        [MenuItem("Tools/Plugin Master/" + TOOL_NAME, true, int.MaxValue)]
        private static bool CheckIsNotPlaying() => !Application.isPlaying;

        [MenuItem("Tools/Plugin Master/" + TOOL_NAME, false, int.MaxValue)]
        private static void ShowWindow() => GetWindow<PlayModeSave>();
        
        private void OnGUI()
        {
            titleContent = new GUIContent(TOOL_NAME);
            if (Application.isPlaying) return;
            using (new EditorGUILayout.VerticalScope())
            {
                _autoApply = EditorGUILayout.ToggleLeft("Auto-Apply All Changes On Exit Play Mode", _autoApply);
                if (_autoApply)
                {
                    maxSize = minSize = new Vector2(270, 24);
                    return;
                }
                maxSize = minSize = new Vector2(270, 44);
                if (_toApply.Count == 0)
                {
                    EditorGUILayout.LabelField("Nothing to apply");
                    return;
                }
                using (new EditorGUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Apply All Changes")) ApplyAll();
                    GUILayout.FlexibleSpace();
                }
            }
        }
        #endregion

        #region SAVE
        private static bool _autoApply = true;
        private class TransformData
        {
            public Vector3 position;
            public Quaternion rotation;
            public Vector3 scale;
            public TransformData(Transform transform) => (position, rotation, scale) = (transform.localPosition, transform.localRotation, transform.localScale);
            public static implicit operator TransformData(Transform transform) => new TransformData(transform);
            public virtual void Apply(Transform transform)
            {
                transform.localPosition = position;
                transform.localRotation = rotation;
                transform.localScale = scale;
            }
        }

        private class RectTransformData : TransformData
        {
            public Vector2 sizeDelta;
            public Vector2 anchorMin;
            public Vector2 anchorMax;
            public Vector2 pivot;
            public RectTransformData(RectTransform transform) : base(transform) => (sizeDelta, anchorMin, anchorMax, pivot) = (transform.sizeDelta, transform.anchorMin, transform.anchorMax, transform.pivot);
            public static implicit operator RectTransformData(RectTransform transform) => new RectTransformData(transform);
            public override void Apply(Transform transform)
            {
                var rectTransform = transform.GetComponent<RectTransform>();
                if (rectTransform != null)
                {
                    rectTransform.sizeDelta = sizeDelta;
                    rectTransform.anchorMin = anchorMin;
                    rectTransform.anchorMax = anchorMax;
                    rectTransform.pivot = pivot;
                }
                base.Apply(transform);
            }
        }

        private static Dictionary<int, TransformData> _saveData = new Dictionary<int, TransformData>();
        private static List<int> _toApply = new List<int>();

        private static void Add(Transform transform)
        {
            var instanceId = transform.gameObject.GetInstanceID();
            var data = transform is RectTransform ? new RectTransformData(transform as RectTransform) as TransformData : transform;
            if (_saveData.ContainsKey(instanceId))
            {
                _saveData[instanceId] = data;
            }
            else
            {
                _saveData.Add(instanceId, data);
                _toApply.Add(instanceId);
            }
        }

        private static void RemoveNewObjects()
        {
            var ids = _toApply.ToArray();
            foreach (var id in ids)
            {
                var obj = EditorUtility.InstanceIDToObject(id) as GameObject;
                if (obj != null) continue;
                _saveData.Remove(id);
                _toApply.Remove(id);
            }
        }

        private static void Apply(int instanceId)
        {
            var obj = EditorUtility.InstanceIDToObject(instanceId) as GameObject;
            if (obj == null) return;
            var data = _saveData[instanceId];
            Undo.RecordObject(obj.transform, TOOL_NAME);
            data.Apply(obj.transform);
        }

        private static void ApplyAll()
        {
            var ids = _toApply.ToArray();
            foreach (var id in ids) Apply(id);
        }

        [InitializeOnLoadAttribute]
        private static class PlayModeStateChanged
        {
            private static GameObject AutoApplyFlag = null;
            private const string OBJECT_NAME = "PlayModeSave_AutoApply";

            static PlayModeStateChanged() => EditorApplication.playModeStateChanged += OnStateChanged;

            private static void OnStateChanged(PlayModeStateChange state)
            {
                if (state == PlayModeStateChange.ExitingEditMode && _autoApply)
                {
                    AutoApplyFlag = new GameObject(OBJECT_NAME);
                    AutoApplyFlag.hideFlags = HideFlags.HideAndDontSave;
                    return;
                }
                if (state != PlayModeStateChange.EnteredEditMode) return;
                PlayModeSave.RemoveNewObjects();
                AutoApplyFlag = GameObject.Find(OBJECT_NAME);
                _autoApply = AutoApplyFlag != null;
                if (!_autoApply) return;
                DestroyImmediate(AutoApplyFlag);
                PlayModeSave.ApplyAll();
            }
        }
        #endregion
    }
}