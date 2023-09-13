using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languageSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    bool flag = false;
    public Text portal;
    public Dropdown tenGuardiansRocks;
    public Text cancelNavigation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag){
            portal.text = "傳送們";
            cancelNavigation.text = "取消導航";
            tenGuardiansRocks.options[0].text = "取消導航";
            tenGuardiansRocks.options[1].text = "山豬岩";
            tenGuardiansRocks.options[2].text = "花豹岩";
            tenGuardiansRocks.options[3].text = "黑鳶岩";
            tenGuardiansRocks.options[4].text = "海蛞蝓岩";
            tenGuardiansRocks.options[5].text = "鱷魚岩";
            tenGuardiansRocks.options[6].text = "法老岩";
            tenGuardiansRocks.options[7].text = "人面獅身岩";
            tenGuardiansRocks.options[8].text = "海豹岩";
            tenGuardiansRocks.options[9].text = "彈塗魚岩";
        }
        else{
            portal.text = "portal";
            cancelNavigation.text = "Cancel navigation";
            tenGuardiansRocks.options[0].text = "Cancel navigation";
            tenGuardiansRocks.options[1].text = "Wild Boar Rock";
            tenGuardiansRocks.options[2].text = "Leopard Rock";
            tenGuardiansRocks.options[3].text = "Black Kite Rock";
            tenGuardiansRocks.options[4].text = "Sea ​​Slug Rock";
            tenGuardiansRocks.options[5].text = "Crocodile Rock";
            tenGuardiansRocks.options[6].text = "Pharaoh Rock";
            tenGuardiansRocks.options[7].text = "Sphinx Rock";
            tenGuardiansRocks.options[8].text = "Seal Rock";
            tenGuardiansRocks.options[9].text = "Mudskipper Rock";
        }
    }
}
