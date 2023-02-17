using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Animations;
public class Motorboat: MonoBehaviour
{
    public GameObject player;
     public float thrustForce = 50000;
     public float torque = 5000;
      bool isOperated = false;
      private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.B) && isOperated == false){
             isOperated = true;
             player.GetComponent<PlayerControl>().enabled = false;
             player.AddComponent<ParentConstraint>();
             ConstraintSource constraintSource = new ConstraintSource(){
                sourceTransform = transform;
                 weight = 1;
             };
            player.GetComponent<ParentConstraint>().SetSources(new List<ConstraintSource>(){constraintSource});    
            player.GetComponent<ParentConstraint>().SetTranslationOffset(0,new Vector3(0,0.3f,0));
           player.GetComponent<ParentConstraint>().constraintActive = true;
        } 
         else if(Input.GetKeyDown(KeyCode.B) && isOperated == true){
            isOperated = false;
            player.GetComponent<PlayerControl>().enabled = true;
            player.GetComponent<ParentConstraint>().SetSources(new List<ConstraintSource>());
            player.GetComponent<ParentConstraint>().constraintActive = false;
            Destroy(player.GetComponent<ParentConstraint>());

         }*/
         Move();
    }
     void Move(){
         //if(!isOperated) return;
         float v = Input.GetAxis("Vertical");
         float h = Input.GetAxis("Horizontal");
          rigidbody.AddForce(transform.forward * v * thrustForce);
          rigidbody.AddTorque(transform.up * h * torque);
     }
}
