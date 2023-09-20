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
    public GameObject TheBoarHead;
    public GameObject TheLeopard;
    public GameObject TheBlackKite;
    public GameObject TheSeaHare;
    public GameObject TheCrocodile;
    public GameObject ThePharaoh;
    public GameObject TheSphinx;
    public GameObject TheSeal;
    public GameObject TheMudskipper;
    public Text toggleDropdwon;
    public Text togglePortal;
    public Text toggleBgm;
    public Text toggleTime;
    public Text toggleLight; 

    void Start()
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
            TheBoarHead.tag = "山豬岩";
            TheLeopard.tag = "花豹岩";
            TheBlackKite.tag = "黑鳶岩";
            TheSeaHare.tag = "海蛞蝓岩";
            TheCrocodile.tag = "鱷魚岩";
            ThePharaoh.tag = "法老岩";
            TheSphinx.tag = "人面獅身岩";
            TheSeal.tag = "海豹岩";
            TheMudskipper.tag = "彈塗魚岩";
            toggleDropdwon.text = "導航";
            togglePortal.text = "傳送門";
            toggleBgm.text = "Bgm";
            toggleTime.text = "顯示時間";
            toggleLight.text = "光源調節";
        }
        else{
            portal.text = "portal";
            cancelNavigation.text = "Cancel Navigation";
            tenGuardiansRocks.options[0].text = "Cancel Navigation";
            tenGuardiansRocks.options[1].text = "The Boar Head";
            tenGuardiansRocks.options[2].text = "The Leopard";
            tenGuardiansRocks.options[3].text = "The Black Kite";
            tenGuardiansRocks.options[4].text = "The Sea Hare";
            tenGuardiansRocks.options[5].text = "The Crocodile";
            tenGuardiansRocks.options[6].text = "The Pharaoh";
            tenGuardiansRocks.options[7].text = "The Sphinx";
            tenGuardiansRocks.options[8].text = "The Seal";
            tenGuardiansRocks.options[9].text = "The Mudskipper";
            TheBoarHead.tag = "The Boar Head";
            TheLeopard.tag = "The Leopard";
            TheBlackKite.tag = "The Black Kite";
            TheSeaHare.tag = "The Sea Hare";
            TheCrocodile.tag = "The Crocodile";
            ThePharaoh.tag = "The Pharaoh";
            TheSphinx.tag = "The Sphinx";
            TheSeal.tag = "The Seal";
            TheMudskipper.tag = "The Mudskipper";
            toggleDropdwon.text = "Navigation";
            togglePortal.text = "Portal";
            toggleBgm.text = "Bgm";
            toggleTime.text = "Display Time";
            toggleLight.text = "Light Source Adjustment";
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
