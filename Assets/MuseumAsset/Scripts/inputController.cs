using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    public GameObject museum;
    public GameObject targetPoint;
    public GameObject btn;
    public GameObject text;
    public GameObject image;
    List<GameObject> instantiatedPrefabs = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEndEdit(string str){
        bool flag = false;
        if(instantiatedPrefabs != null){
            foreach(GameObject prefabs in instantiatedPrefabs){
                Destroy(prefabs);
            }
        }
        foreach(Transform child in museum.transform){
            if(child.gameObject.name.Contains(str)){
                flag = true;
                targetPoint.SetActive(true);
                GameObject insTargetPoint = Instantiate(targetPoint);
                insTargetPoint.transform.position = new Vector3(child.position.x, child.position.y + 9, child.position.z);
                instantiatedPrefabs.Add(insTargetPoint);
            } 
        }
        if(!flag){
            text.gameObject.SetActive(true);
            btn.gameObject.SetActive(true);
            image.gameObject.SetActive(true);
            foreach(GameObject prefabs in instantiatedPrefabs){
                Destroy(prefabs);
            }
        }
    }

    public void Confirm(){
        text.gameObject.SetActive(false);
        btn.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }
}
