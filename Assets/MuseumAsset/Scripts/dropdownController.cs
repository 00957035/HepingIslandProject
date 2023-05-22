using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownController : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public GameObject museum;
    public GameObject spotlight;
    List<GameObject> flag = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(int num){
        if(flag != null){
            foreach(GameObject prefab in flag){
                Destroy(prefab);
            }
        }
        foreach(Transform child in museum.transform){
            if(child.gameObject.tag == dropdown.options[num].text){
                spotlight.SetActive(true);
                GameObject insSpotlight = Instantiate(spotlight);
                insSpotlight.transform.position = new Vector3(child.position.x, child.position.y + 5, child.position.z);
                flag.Add(insSpotlight);
            }
        }
    }

}
