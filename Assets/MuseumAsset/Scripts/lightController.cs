using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject directional_light;
    Light lightComponent;
    public GameObject slider;
    void Start()
    {
        lightComponent = directional_light.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onValueChanged(float value){
        lightComponent.intensity = slider.GetComponent<Slider>().value;
        Debug.Log(lightComponent.intensity);
        Debug.Log(value);
    }
}
