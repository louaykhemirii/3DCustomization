using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    public string[] Animations;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Movement1(int index)
    {
        string animationName = Animations[index];
        anim.Play(Animations[index]);

    }
}
