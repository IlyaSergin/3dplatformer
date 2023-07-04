using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private string sceneName = "Level_1";
    void OnTriggerEnter()
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}

