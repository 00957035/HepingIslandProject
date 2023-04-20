using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class productIntro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject third;
    Transform myTransform;
    Transform childTransform; 

    GameObject childObject;

    void Start()
    {
        Transform myTransform = transform;
        Transform childTransform = myTransform.Find("Canvas");
        if(childTransform != null){
            childObject = childTransform.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "ThirdPersonController"){
            childObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.name == "ThirdPersonController"){
            childObject.SetActive(false);
        }
    }
}
