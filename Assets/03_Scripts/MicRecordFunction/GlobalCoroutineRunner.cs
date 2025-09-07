using UnityEngine;
using System.Collections;

public class GlobalCoroutineRunner : MonoBehaviour
{
    private static GlobalCoroutineRunner _instance;
    public static GlobalCoroutineRunner Instance {
        get {
            if (_instance == null) {
                var go = new GameObject("~GlobalCoroutineRunner");
                Object.DontDestroyOnLoad(go);
                _instance = go.AddComponent<GlobalCoroutineRunner>();
            }
            return _instance;
        }
    }

    public static Coroutine Run(IEnumerator routine) => Instance.StartCoroutine(routine);
}