using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{ 

    public string sceneName;
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
