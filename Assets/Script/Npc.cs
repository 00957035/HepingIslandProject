using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   /*void OnTriggerEnter(Collider other){
      dialogue.SetActive(true);
   }
   void OnTriggerExit(Collider other){
     dialogue.SetActive(false);
   }*/
    void OnMouseDown(){
        dialogue.SetActive(true);
    }
}
