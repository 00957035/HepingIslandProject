using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float speed = 5f; //移動速度
    private Transform m_Transform;
    void Start(){
        m_Transform = this.transform;
    }
    void Update()
    {
        /*float x = Input.GetAxis("Horizontal"); //input水平
        float z = Input.GetAxis("Vertical"); //input垂直

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);*/
        playerMove();
    }
    void playerMove(){
        if(Input.GetKey(KeyCode.Q)){ //左前
            Debug.Log("Q");
            m_Transform.localRotation = Quaternion.Euler(0, -5, 0);
            m_Transform.Translate(new Vector3(-1, 0, 1)*speed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey(KeyCode.W)){ //右前
            Debug.Log("W");
            m_Transform.localRotation = Quaternion.Euler(0, 5, 0);
            m_Transform.Translate(new Vector3(1, 0, 1)*speed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey(KeyCode.A)){ //左後
            Debug.Log("A");
            m_Transform.localRotation = Quaternion.Euler(0, -5, 0);
            m_Transform.Translate(new Vector3(-1, 0, -1)*speed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey(KeyCode.S)){ //右後
            Debug.Log("S");
            m_Transform.localRotation = Quaternion.Euler(0, 5, 0);
            m_Transform.Translate(new Vector3(1, 0, -1)*speed*Time.deltaTime, Space.World);
        }
    }
}