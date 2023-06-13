using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTest : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseX = Input.GetAxis("Mouse X");
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        if (h > 0)
        {
            print("往右");
            // 向右移动，顺时针旋转
            //transform.Rotate(Vector3.forward, speed * Time.deltaTime);

        }
        else if (h < 0)
        {
            print("往左");
            // 向左移动，逆时针旋转
            //transform.Rotate(Vector3.back, speed * Time.deltaTime);
        }
        transform.Rotate(v, h, 0);
    }
}

