using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField]
    public Material[] Materials;
    private Renderer myRenderer;

    // Unique identifier for each clothing part (adjust these as needed)
    private const string shortKey = "ShortMaterialIndex";
    private const string tShirtKey = "TShirtMaterialIndex";
    private const string hairKey = "HairMaterialIndex";
    private const string shoesKey = "ShoesMaterialIndex";
    private const string GlassesKey = "GlaseesMaterialIndex";
    private const string CapKey = "CapMaterialIndex";
    private const string Shoes2Key = "Shoes2MaterialIndex";

    private void Start()
    {
        // Get the Renderer component from the GameObject
        myRenderer = GetComponent<Renderer>();

        // Load the saved material index for each clothing part
        LoadMaterialIndex();
    }

    // Function to change the material and save the material index
    public void ChangeMaterial(int index)
    {
        myRenderer.material = Materials[index];

        // Save the selected material index based on the clothing part
        switch (gameObject.tag)
        {
            case "Short":
                PlayerPrefs.SetInt(shortKey, index);
                break;
            case "TShirt":
                PlayerPrefs.SetInt(tShirtKey, index);
                break;
            case "Hair":
                PlayerPrefs.SetInt(hairKey, index);
                break;
            case "Shoes":
                PlayerPrefs.SetInt(shoesKey, index);
                break; 
            case "Glasses":
                PlayerPrefs.SetInt(GlassesKey, index);
                break;
            case "Cap":
                PlayerPrefs.SetInt(CapKey, index);
                break;case "Shoes2":
                PlayerPrefs.SetInt(Shoes2Key, index);
                break;
        }

        PlayerPrefs.Save();
    }

    // Function to load the saved material index for each clothing part
    private void LoadMaterialIndex()
    {
        int index=6 ; // Default index in case there is no saved value

        switch (gameObject.tag)
        {
            case "Short":
                if (PlayerPrefs.HasKey(shortKey))
                {
                    index = PlayerPrefs.GetInt(shortKey);
                }
                break;
            case "TShirt":
                if (PlayerPrefs.HasKey(tShirtKey))
                {
                    index = PlayerPrefs.GetInt(tShirtKey);
                }
                break;
            case "Hair":
                if (PlayerPrefs.HasKey(hairKey))
                {
                    index = PlayerPrefs.GetInt(hairKey);
                }
                break;
            case "Shoes":
                if (PlayerPrefs.HasKey(shoesKey))
                {
                    index = PlayerPrefs.GetInt(shoesKey);
                }
                break;
            case "Glasses":
                if (PlayerPrefs.HasKey(GlassesKey))
                {
                    index = PlayerPrefs.GetInt(GlassesKey);
                }
                break;
            case "Cap":
                if (PlayerPrefs.HasKey(CapKey))
                {
                    index = PlayerPrefs.GetInt(CapKey);
                }
                break;
                //a part of the shoes 
            case "Shoes2":
                if (PlayerPrefs.HasKey(Shoes2Key))
                {
                    index = PlayerPrefs.GetInt(Shoes2Key);
                }
                break;
        }

        // Apply the saved material index
        myRenderer.material = Materials[index];
    }
}
