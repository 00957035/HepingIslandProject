using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thirdPerson;
    Vector3 third;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(thirdPerson.transform.position.x, thirdPerson.transform.position.y + 8, thirdPerson.transform.position.z);
    }
}
