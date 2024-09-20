using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public static bool Glasses = false;
    public static bool Shirt = false;
    public static bool Shoes = false;
    public static bool Hair = false;
    public static bool Pants = false;
    public static bool Animation = false;
    public static bool Cap = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void clicked()
    {
        Glasses = true;
        Shoes = false;
        Hair = false;
        Shirt = false;
        Pants = false;
        Animation = false;
        Cap = false;
    }
    public void shoesClicked()
    {
        Shoes = true;
        Glasses = false;
        Hair = false;
        Shirt = false;
        Pants = false;
        Animation = false;
        Cap = false;
    }
    public void HairClicked()
    {
        Hair = true;
        Glasses = false;
        Shoes = false;
        Shirt = false;
        Pants = false;
        Animation = false;
        Cap = false;
    }
    public void ShirtClicked()
    {
        Shirt = true;
        Glasses = false;
        Shoes = false;
        Hair = false;
        Pants = false;
        Animation = false;
        Cap = false;
    }
    public void PantstClicked()
    {
        Pants = true;
        Glasses = false;
        Shoes = false;
        Hair = false;
        Shirt = false;
        Animation = false;
        Cap = false;

    }
    public void AnimationClicked()
    {
        Animation = true;
        Pants = false;
        Glasses = false;
        Shoes = false;
        Hair = false;
        Shirt = false;
        Cap = false;


    }
    public void CapClicked()
    {
        Cap = true;
        Glasses = false;
        Shoes = false;
        Hair = false;
        Shirt = false;
        Animation = false;
        Pants = false;

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void BackgroundClick()
    {
        Glasses = false;
        Shoes = false;
        Hair = false;
        Shirt = false;
        Pants = false;
        Animation = false;
        Cap = false;
    }
}
