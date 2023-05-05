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
    GameObject targetPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEndEdit(string str){
        searchTransform = museum.transform.Find(str);
        targetPoint = museum.transform.Find("targetPoint").gameObject;
        targetPoint.SetActive(true);
        targetPoint.transform.position = new Vector3(searchTransform.position.x, searchTransform.position.y + 5, searchTransform.position.z + 4);
    }
}
