using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeWriterEffect : MonoBehaviour
{
    // Start is called before the first frame update
    Text showText;
    string showStr;
    void Start()
    {
        showText =GetComponent<Text>();
        showStr="歡迎加入獨木舟遊戲";
        StartCoroutine(TypeText());
    }
    private IEnumerator TypeText(){
        foreach(var item in showStr.ToCharArray()){
            showText.text+= item;
            yield return new WaitForSeconds(0.5f);
        }
    }
    // Update is called once per frame
    
}
