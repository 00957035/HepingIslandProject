using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastController : MonoBehaviour
{
    // Start is called before the first frame update
    string name = "";
    string tempname = "";
    float timer = 0.0f;
    Transform otherTransform;
    Transform otherChildTransform; 

    GameObject otherChildObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            name = hit.collider.gameObject.name;
            //Debug.Log(name);
            if(name == tempname){
                timer += Time.deltaTime;
            }
            else{
                timer = 0;
            }
            if(timer >= 2.0f){
                Debug.Log("應該要有");
                otherTransform = hit.collider.gameObject.transform;
                otherChildTransform = otherTransform.Find("infoCanvas");
                if(otherChildTransform != null){
                    otherChildObject = otherChildTransform.gameObject;
                    otherChildObject.SetActive(true);
                    Debug.Log(otherChildObject);
                }
            }
            else{
                if(otherChildObject != null){
                    otherChildObject.SetActive(false);
                }
            }
            tempname = hit.collider.gameObject.name;
        }
    }
}
