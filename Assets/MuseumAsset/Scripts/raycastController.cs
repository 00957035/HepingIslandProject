using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastController : MonoBehaviour
{
    // Start is called before the first frame update
    string name = "";
    string tempname = "";
    float timer = 0.0f;
    Transform remindTransform; //提醒
    Transform remindChildTransform;
    GameObject remindGameObject;
    Transform otherTransform; //介紹
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
            if(timer >= 0.2){
                remindTransform = hit.collider.gameObject.transform;
                remindChildTransform = remindTransform.Find("reminderCanvas");
                if(remindChildTransform != null){
                    remindGameObject = remindChildTransform.gameObject;
                    remindGameObject.SetActive(true);
                }
            }
            else{
                if(remindGameObject != null){
                    remindGameObject.SetActive(false);
                }
            }
            if(timer >= 2.0f){
                if(remindGameObject != null){
                    remindGameObject.SetActive(false);
                }
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
