using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManager;

public class change_Scene : MonoBehaviour
{
    public string sceneName;
    
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
