using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string menuSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("death") && gameObject.CompareTag("Entity"))
        {
            Debug.Log("Collision detected with Death object.");
            SceneManager.LoadScene(menuSceneName);
        }
    }
}

