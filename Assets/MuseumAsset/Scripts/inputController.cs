using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    public GameObject museum;
    Transform searchTransform;
    public GameObject targetPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEndEdit(string str){
        foreach(Transform child in museum.transform){
            if(child.gameObject.name.Contains(str)){
                targetPoint.SetActive(true);
                GameObject insTargetPoint = Instantiate(targetPoint);
                insTargetPoint.transform.position = new Vector3(child.position.x, child.position.y + 12, child.position.z);
            }
        }
       
    }
}
