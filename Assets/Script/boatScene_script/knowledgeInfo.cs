using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knowledgeInfo : MonoBehaviour
{
    public GameObject ShowPanel;
    public GameObject ShowPanelText;
    public string KnowledgeNumber = null;
    public string KnowledgeInfo = null;
    void OnMouseDown(){        
        ShowPanel.SetActive(true);
        ShowPanel.GetComponent<knowledgePanelInfo>().KnowledgeNumber = KnowledgeNumber;
        ShowPanel.GetComponent<knowledgePanelInfo>().KnowledgeInfo = KnowledgeInfo;
        ShowPanelText.GetComponent<showKnowledgeInfo>().Start();
        //Debug.Log(KnowledgeNumber);
        //gameObject.GetComponent<knowledgeInfo>().ShowPanel.SetActive(true);
        // dialogue.SetActive(true);
    }
}
