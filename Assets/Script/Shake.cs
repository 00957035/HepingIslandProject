using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{   float z_speed = 3.0f;
    float x_speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.eulerAngles.z >= 4 && this.transform.eulerAngles.z <= 180){
            z_speed = -z_speed;
        }
        else if (this.transform.eulerAngles.z <=(360 - 4) && this.transform.eulerAngles.z >=180){
            z_speed = -z_speed;
        }
         if(this.transform.eulerAngles.x >= 4 && this.transform.eulerAngles.x <= 180){
            x_speed = -x_speed;
        }
        else if (this.transform.eulerAngles.x <=(360 - 4) && this.transform.eulerAngles.x >=180){
            x_speed = -x_speed;
        }
         this.transform.Rotate(z_speed * Time.deltaTime,0,z_speed * Time.deltaTime);
    }
}
