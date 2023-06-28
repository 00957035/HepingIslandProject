using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alert : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    public GameObject button;
    bool pressed = false;
    float startTime = 0.0f;
    float endTime = 0.0f;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        endTime = Time.time - startTime;
        if(endTime > 5 && pressed == false){
            text.gameObject.GetComponent<Text>().text = "你已經玩了" + (int)endTime + "秒，該休息了!";
            text.SetActive(true);
            button.SetActive(true);
        }
        
    }

    public void Pressed(){
        text.SetActive(false);
        button.SetActive(false);
        pressed = true;
    }
}
