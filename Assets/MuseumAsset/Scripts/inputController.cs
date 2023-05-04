using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEndEdit(string str){
        Debug.Log(str);
    }
}
