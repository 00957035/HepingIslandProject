using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRole : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Avatar[] avatar;
    public GameObject[] role;
    int selectedNum;
    void Start()
    {
        selectedNum = characterManager.selectedOption;
        role[0].SetActive(false);
        role[selectedNum].SetActive(true);
        
        animator.avatar = avatar[selectedNum];
        Debug.Log(selectedNum);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
