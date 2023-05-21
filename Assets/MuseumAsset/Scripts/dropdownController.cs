using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownController : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(int num){
        Debug.Log(dropdown.options[num].text);
    }

}
