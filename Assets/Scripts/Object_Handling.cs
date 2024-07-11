using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandling : MonoBehaviour
{
    public Camera mainCamera;
    private Rigidbody selectedObject;
    private float initialDistance;
    private bool isDragging = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 3f))
            {
                if (hit.rigidbody != null)
                {
                    selectedObject = hit.rigidbody;
                    initialDistance = Vector3.Distance(mainCamera.transform.position, selectedObject.transform.position);
                    isDragging = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            selectedObject = null;
        }

        if (isDragging && selectedObject != null)
        {
            Vector3 mousePos = GetMouseAsWorldPoint(initialDistance);
            selectedObject.transform.position = mousePos;
        }
    }

    private Vector3 GetMouseAsWorldPoint(float distance)
    {
        Ray mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        return mouseRay.GetPoint(distance);
    }
}
