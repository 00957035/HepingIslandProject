using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;
        int hour = currentTime.Hour;
        int min = currentTime.Minute;
        int sec = currentTime.Second;
        if(hour < 10 && min < 10 && sec < 10){
            text.text = "0" + hour + " : " + "0" + min + " : " + "0" + sec;
        }
        else if(hour < 10 && min < 10){
            text.text = "0" + hour + " : " + "0" + min + " : " + sec;
        }
        else if(hour < 10 && sec < 10){
            text.text = "0" + hour + " : " + min + " : " + "0" + sec;
        }
        else if(min < 10 && sec < 10){
            text.text = hour + " : " + "0" + min + " : " + "0" + sec;
        }
        else if(hour < 10){
            text.text = "0" + hour + " : " + min + " : " + sec;
        }
        else if(min < 10){
            text.text = hour + " : " + "0" + min + " : " + sec;
        }
        else if(sec < 10){
            text.text = hour + " : " + min + " : " + "0" + sec;
        }
        else{
            text.text = hour + " : " + min + " : " + sec;
        }
    }
}
