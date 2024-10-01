using UnityEngine;
public class ViewpointRotater : MonoBehaviour
{
    Vector3 lastMousePosition;
    Vector3 newAngle;
    [SerializeField]
    float rotateLimit;
    [SerializeField]
    float rotateSpeed;
    float cursorMoveLimit;
    void Start()
    {
        newAngle = transform.localEulerAngles;
        lastMousePosition = Input.mousePosition;
        newAngle = new(0, 0, 0);
        cursorMoveLimit = 450;
        Cursor.visible = false;
    }
    void CameraRotation()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            newAngle.y += (Input.mousePosition.x - lastMousePosition.x) * rotateSpeed * Time.deltaTime;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotateSpeed * Time.deltaTime;
            newAngle.x = Mathf.Min(newAngle.x, rotateLimit);
            newAngle.x = Mathf.Max(newAngle.x, -rotateLimit);
            gameObject.transform.localEulerAngles = newAngle;
        }
        if (Mathf.Abs(Screen.width * 0.5f - Input.mousePosition.x) > cursorMoveLimit ||
        Mathf.Abs(Screen.height * 0.5f - Input.mousePosition.y) > cursorMoveLimit)
        {
            Cursor.lockState = CursorLockMode.Locked;
            lastMousePosition = Input.mousePosition;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            lastMousePosition = Input.mousePosition;
        }
    }
    void FixedUpdate()
    {
        CameraRotation();
    }
}