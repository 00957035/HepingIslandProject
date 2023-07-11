using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QandA : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject response;
    string [] plants = new string [] {"麒麟花", "黃紋龍舌蘭", "蒲葵", "草海桐", "文殊蘭", "厚葉石斑木", "銀葉鈕扣樹",
    "蘄艾", "木麻黃", "大葉山欖", "欖仁樹", "白水木", "中東海棗", "臺灣海棗", "苧麻", "濱槐", "林投", "雙花蟛蜞菊",
    "海桐", "射干", "蜘蛛百合", "臺灣蘆竹"};
    void Start()
    {
        for(int i = 0; i < 4; i++){
            int randomNum = Random.Range(0,23);
            if(i == 0){
                GameObject text = button1.transform.GetChild(0).gameObject;
                text.GetComponent<Text>().text = plants[randomNum];
            }
            else if(i == 1){
                GameObject text = button2.transform.GetChild(0).gameObject;
                text.GetComponent<Text>().text = plants[randomNum];
            }
            else if(i == 2){
                GameObject text = button3.transform.GetChild(0).gameObject;
                text.GetComponent<Text>().text = plants[randomNum];
            }
            else{
                GameObject text = button4.transform.GetChild(0).gameObject;
                text.GetComponent<Text>().text = plants[randomNum];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick(){//還要再加判斷有沒有被選過，以及答案是否正確
        response.GetComponent<Text>().text = "恭喜你答對了!";
    }

    public void Exit(){
        canvas.SetActive(false);
    }
}
