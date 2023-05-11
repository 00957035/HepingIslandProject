using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arenaUpdate : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "十大守護岩區";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Cube.004"){
            text.text = "人文區";
        }
        else if(other.gameObject.name == "Cube.002"){
            text.text = "自然區";
        }
        else{
            text.text = "十大守護岩區";
        }
    }
}
