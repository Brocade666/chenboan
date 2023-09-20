using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public Animator anim;
    public void Click(){
        Debug.Log("click button");

        bool isOperated = anim.GetBool("isOperated");
        anim.SetBool("isOperated", !isOperated);
    }
}
