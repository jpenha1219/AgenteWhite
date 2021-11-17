using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    Vector2 touchDetaPosition;
    void Start()
    {
        if (Input.GetMouseButton(1))
        {
            float pointer_y = Input.GetAxis("Mouse X");
            float pointer_x = Input.GetAxis("Mouse Y");
            transform.Translate(pointer_x * 0.5f, pointer_y * 0.5f, 0);
        }
        if (Input.touchCount == 1)
        {
            Touch touchZero = Input.GetTouch(0);
            if (touchZero.phase == TouchPhase.Moved)
            {
                touchDetaPosition = Input.GetTouch(0).deltaPosition;
                gameObject.transform.Rotate(touchDetaPosition.y * .05f, -touchDetaPosition.x * .4f, 0);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
