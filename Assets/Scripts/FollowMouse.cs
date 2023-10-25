using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Transform entityTransform;

    private void Start()
    {
        entityTransform = GameObject.Find("Entity").GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f;

        if (entityTransform != null)
        {
            entityTransform.position = mousePosition;
        }
        else
        {
            Debug.LogError("Make sure there's a GameObject named 'Entity' in the scene.");
        }
    }
}
