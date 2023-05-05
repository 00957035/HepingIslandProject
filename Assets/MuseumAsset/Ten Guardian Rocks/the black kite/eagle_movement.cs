using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_movement : MonoBehaviour
{
    private GameObject eagle;
    private Vector3 standard;
    private int timer;
    private int move;
    // Start is called before the first frame update
    void Start()
    {
        eagle = GameObject.Find("Eagle");
        timer = 135;
        move = -1;
        standard= new Vector3(0.00f, 0.01f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        while (timer >=135)
        {
            standard = new Vector3(0.0f, 0.01f, 0.0f);
            timer = 134;
            move = -1;
        }
        while (timer <= 0)
        {
            standard = new Vector3(0.0f, -0.01f, 0.0f);
            timer = 1;
            move = 1;
        }
        timer += move;
        eagle.transform.localPosition += standard;
        
    }
}
