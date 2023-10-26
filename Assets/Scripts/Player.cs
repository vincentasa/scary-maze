using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowMouse : MonoBehaviour
{

    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("Wall"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
