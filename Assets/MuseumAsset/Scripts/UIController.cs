using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dropdown;
    public GameObject portal;
    public GameObject bgm;
    public GameObject time;
    public GameObject directional_light;
    public GameObject dropdownToggle;
    public GameObject portalToggle;
    public GameObject bgmToggle;
    public GameObject timeToggle;
    public GameObject lightToggle;

    bool dropdownFlag = false;
    bool portalFlag = false;
    bool bgmFlag = false;
    bool timeFlag = false;
    bool lightFlag = false;
    bool toggleFlag = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleShow(){
        if(toggleFlag){
            dropdownToggle.SetActive(true);
            portalToggle.SetActive(true);
            bgmToggle.SetActive(true);
            timeToggle.SetActive(true);
            lightToggle.SetActive(true);
        }
        else{   
            dropdownToggle.SetActive(false);
            portalToggle.SetActive(false);
            bgmToggle.SetActive(false);
            timeToggle.SetActive(false);
            lightToggle.SetActive(false);
        }
        toggleFlag = !toggleFlag;
    }

    public void dropdownchanged(){
        if(dropdownFlag){
            dropdown.SetActive(true);
        }
        else{
            dropdown.SetActive(false);
        }
        dropdownFlag = !dropdownFlag;
    }

    public void portalchanged(){
         if(portalFlag){
            portal.SetActive(true);
        }
        else{
            portal.SetActive(false);
        }
        portalFlag = !portalFlag;
    }

    public void bgmchanged(){
         if(bgmFlag){
            bgm.SetActive(true);
        }
        else{
            bgm.SetActive(false);
        }
        bgmFlag = !bgmFlag;
    }

    public void timechanged(){
        if(timeFlag){
            time.SetActive(true);
        }
        else{
            time.SetActive(false);
        }
        timeFlag = !timeFlag;
    }

    public void lightchanged(){
        if(lightFlag){
            directional_light.SetActive(true);
        }
        else{
            directional_light.SetActive(false);
        }
        lightFlag = !lightFlag;
    }
}
