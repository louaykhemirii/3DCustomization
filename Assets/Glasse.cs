using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasse : MonoBehaviour
{
    public static  bool Glasses = false;
    public static  bool Shirt = false;
    public static  bool Shoes = false;
    public static  bool Hair = false;
    public static  bool Pants = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void clicked ()
    {
        Glasses= true;
        
    }
    public void shoesClicked ()
    {
        Shoes= true;
        
    }
    public void HairClicked ()
    {
        Hair= true;
        
    }
    public void ShirtClicked ()
    {
        Shirt= true;
        
    }
    public void PantstClicked ()
    {
        Pants= true;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackgroundClick()
    {
        Glasses = false;
        Shoes = false;
        Hair =false;
        Shirt = false;
        Pants = false;

    }
}
