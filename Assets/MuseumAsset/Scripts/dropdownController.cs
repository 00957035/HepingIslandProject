using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class dropdownController : MonoBehaviour //小注意，這是掛在dropdownlist上的，不是人物
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public GameObject artgallery;
    public GameObject spotlight;
    public GameObject thirdPerson;
    List<GameObject> flag = new List<GameObject>();
    LineRenderer line;
    NavMeshAgent agent;
    NavMeshPath path;
    Vector3 searchObjectPosition = new Vector3();
    
    void Start()
    {
        line = thirdPerson.GetComponent<LineRenderer>();
        line.positionCount = 2;
        agent = thirdPerson.GetComponent<NavMeshAgent>(); //獲取人物NavMeshAgent
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown.value != 0){
            NavMesh.CalculatePath(thirdPerson.transform.position, searchObjectPosition, NavMesh.AllAreas, path);
            line.SetPosition(0, path.corners[0]);
            line.SetPosition(1, path.corners[1]);
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
        NavMeshHit navMeshHit;
        if (NavMesh.SamplePosition(searchObjectPosition, out navMeshHit, 100.0f, NavMesh.AllAreas))
        {
            searchObjectPosition = navMeshHit.position;
        }
        NavMesh.CalculatePath(thirdPerson.transform.position, searchObjectPosition, NavMesh.AllAreas, path);
        line.SetPosition(0, path.corners[0]);
        line.SetPosition(1, path.corners[1]);
    }

}
