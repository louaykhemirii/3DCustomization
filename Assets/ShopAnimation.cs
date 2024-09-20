using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAnimation : MonoBehaviour
{
    private Animator anim;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void makeAnimation()
    {
        anim.Play("ShopAnimation");
    }
    public void animationReverse()
    {
       
        anim.Play("ShopAnimationToBack");
    }
}
