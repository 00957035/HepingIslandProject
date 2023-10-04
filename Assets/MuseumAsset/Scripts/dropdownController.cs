using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class dropdownController : MonoBehaviour //小注意，這是掛在dropdownlist上的，不是人物
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public GameObject rocks;
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

        agent = thirdPerson.GetComponent<NavMeshAgent>(); //獲取人物NavMeshAgent
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown.value != 0){ //有選擇物件就導航
            line.positionCount = 2;
            NavMesh.CalculatePath(thirdPerson.transform.position, searchObjectPosition, NavMesh.AllAreas, path);
            line.SetPosition(0, path.corners[0]);
            line.SetPosition(1, path.corners[1]);
            Debug.Log(path.corners[0].GetType());
        }
        else if(dropdown.value == 0){ //選擇取消導航則取消
            line.positionCount = 0;
        }
        float distance = Vector3.Distance(thirdPerson.transform.position, searchObjectPosition);
        if(distance < 2.0){
            dropdown.value = 0;
            line.positionCount = 0;
            if(flag != null){
                foreach(GameObject prefab in flag){
                    Destroy(prefab);
                }
            }
        }
    }

    public void OnValueChanged(int num){
        line.positionCount = 2;
        if(flag != null){
            foreach(GameObject prefab in flag){
                Destroy(prefab);
            }
        }
        foreach(Transform child in rocks.transform){
            if(child.gameObject.tag == dropdown.options[num].text){
                spotlight.SetActive(true);
                GameObject insSpotlight = Instantiate(spotlight);
                insSpotlight.transform.position = new Vector3(child.position.x, child.position.y + 5, child.position.z);
                flag.Add(insSpotlight);
                searchObjectPosition = child.position;
            }
            else{
                spotlight.SetActive(false);
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
