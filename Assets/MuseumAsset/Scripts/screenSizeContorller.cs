using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenSizeContorller : MonoBehaviour
{
    // Start is called before the first frame update
    CanvasScaler canvasScaler;
    void Start()
    {
        canvasScaler = gameObject.GetComponent<CanvasScaler>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasScaler != null){
            canvasScaler.referenceResolution = new Vector2(Screen.width, Screen.height);
        }
    }
}
