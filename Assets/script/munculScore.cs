using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculScore : MonoBehaviour
{
    public Animator anim;
    public GameObject CanvasHasil;

   void Update(){
        if(CanvasHasil.activeSelf ==true)
    {
        anim.SetTrigger("munculSkor");
    }
    }


}