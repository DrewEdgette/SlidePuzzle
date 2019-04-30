using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour
{


    Vector3 moveObject;
    Rigidbody rb;
    private Vector3 curPosition;

    private Vector3 screenPoint;







     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);   // converts screen coords to world coords
    }


    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

        Vector3 cube_mouse_dist = new Vector3(curPosition.x - transform.position.x, 0, 0);
        rb.velocity = cube_mouse_dist * 20;
    }
    
}