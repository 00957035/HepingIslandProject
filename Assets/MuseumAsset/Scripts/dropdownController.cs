using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class dropdownController : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public GameObject artgallery;
    public GameObject spotlight;
    public GameObject thirdPerson;
    List<GameObject> flag = new List<GameObject>();
    LineRenderer line;
    NavMeshAgent agent;
    Vector3 searchObjectPosition = new Vector3();
    
    void Start()
    {
        line = thirdPerson.GetComponent<LineRenderer>();
        line.positionCount = 2;
        agent = thirdPerson.GetComponent<NavMeshAgent>(); //獲取人物NavMeshAgent
    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown.value != 0){
            //line.SetPosition(0, thirdPerson.transform.position);
            //line.SetPosition(1, searchObjectPosition);
        }
    }

    public void OnValueChanged(int num){
        if(flag != null){
            foreach(GameObject prefab in flag){
                Destroy(prefab);
            }
        }
        foreach(Transform child in artgallery.transform){
            if(child.gameObject.tag == dropdown.options[num].text){
                spotlight.SetActive(true);
                GameObject insSpotlight = Instantiate(spotlight);
                insSpotlight.transform.position = new Vector3(child.position.x, child.position.y + 5, child.position.z);
                flag.Add(insSpotlight);
                searchObjectPosition = child.position;
            }
        }
        agent.SetDestination(searchObjectPosition);
    }

}
