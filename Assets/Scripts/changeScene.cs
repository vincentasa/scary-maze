using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_Scene : MonoBehaviour
{
    public string sceneName;
    
    public void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
