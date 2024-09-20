using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 dragStartPosition;
    [SerializeField] float rotationSpeed = 5f;

    void Update()
    {
        if (isDragging)
        {
            // Calculate the difference in mouse position from the drag start position
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 difference = currentMousePosition - dragStartPosition;

            // Calculate the rotation angle around the Y-axis based on the horizontal mouse movement
            float rotationY = difference.x * rotationSpeed;

            // Apply the rotation to the object
            transform.Rotate(0, rotationY, 0, Space.World);

            // Update the drag start position to the current mouse position
            dragStartPosition = currentMousePosition;
        }
    }

    void OnMouseDown()
    {
        // When the mouse is clicked, start dragging the object
        isDragging = true;
        dragStartPosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        // When the mouse is released, stop dragging the object
        isDragging = false;
    }
}
