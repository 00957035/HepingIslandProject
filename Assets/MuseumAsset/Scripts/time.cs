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
        text.text = hour + " : " + min + " : " + sec;
    }
}
