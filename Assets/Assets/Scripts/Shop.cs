using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Shop : MonoBehaviour
{
	#region Singlton:Shop

	public static Shop Instance;

	void Awake ()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy (gameObject);
	}

	#endregion

	[System.Serializable] public class ShopItem
	{
		public Sprite Image;
		public int Price;
		public bool IsPurchased = false;
	}

	public List<ShopItem> ShopItemsList;
	[SerializeField] Animator NoCoinsAnim;
	[SerializeField] MaterialChanger ChangeHair;
	[SerializeField] MaterialChanger ChangeGlasses;
	[SerializeField] MaterialChanger ChangeShoes;
	[SerializeField] MaterialChanger ChangeShoes2;
	[SerializeField] MaterialChanger ChangePants;
	[SerializeField] MaterialChanger ChangeShirts;
	[SerializeField] MaterialChanger ChangeCap;
	[SerializeField] GameObject Glasses, Shoes, Pants, Shirts,Hair;
	[SerializeField] GameObject ItemTemplate;
	GameObject g;
	[SerializeField] Transform ShopScrollView;
	[SerializeField] GameObject ShopPanel;
	[SerializeField] GameObject ShopPanel2;
	private Animator anim;
	Button buyBtn, SelectBtn;
	[SerializeField] float marginTop = 50f; // Adjust this value as needed
	
	void Start ()
	{
		int len = ShopItemsList.Count;
		float yPos = 0f; // Initialize the y-position

		for (int i = 0; i < len; i++)
		{
			g = Instantiate(ItemTemplate, ShopScrollView);

			// Set the y-position with margin-top
			RectTransform itemTransform = g.GetComponent<RectTransform>();
			itemTransform.anchoredPosition = new Vector2(itemTransform.anchoredPosition.x, yPos);

			g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;

			SelectBtn = g.transform.GetComponent<Button>();
			if (ShopItemsList[i].IsPurchased)
			{
				//DisableBuyButton();
			}

			SelectBtn.AddEventListener(i, OnItemClicked);

			// Increment yPos for the next item
			yPos -= (itemTransform.rect.height + marginTop);
		}
	}
   


    /*void OnShopItemBtnClicked (int itemIndex)
	{
		ChangeHair.ChangeMaterial(itemIndex);
		if (Game.Instance.HasEnoughCoins (ShopItemsList [itemIndex].Price)) {
			Game.Instance.UseCoins (ShopItemsList [itemIndex].Price);
			//purchase Item
			ShopItemsList [itemIndex].IsPurchased = true;

			//disable the button
			buyBtn = ShopScrollView.GetChild (itemIndex).GetChild (2).GetComponent <Button> ();
			DisableBuyButton ();
			//change UI text: coins
			Game.Instance.UpdateAllCoinsUIText ();

			//add avatar
			//Profile.Instance.AddAvatar (ShopItemsList [itemIndex].Image);
		} else {
			NoCoinsAnim.SetTrigger ("NoCoins");
			Debug.Log ("You don't have enough coins!!");
		}
	}*/
	void OnItemClicked(int itemIndex)
    {
		Debug.Log("button clicked");
		if(ButtonManager.Glasses)
        {
			ChangeGlasses.ChangeMaterial(itemIndex);
        }
		else if (ButtonManager.Shoes)
		{
			ChangeShoes.ChangeMaterial(itemIndex);
			ChangeShoes2.ChangeMaterial(itemIndex);
		}
		else if (ButtonManager.Hair)
        {
			ChangeHair.ChangeMaterial(itemIndex);
			Debug.Log(Glasse.Hair);
		}
		else if (ButtonManager.Pants)
		{
			ChangePants.ChangeMaterial(itemIndex);
		}
		else if (ButtonManager.Shirt)
		{
			ChangeShirts.ChangeMaterial(itemIndex);
		}
		else if (ButtonManager.Cap)
		{
			ChangeCap.ChangeMaterial(itemIndex);
		}
		/* else
		 {
			 Movement.Movement1(itemIndex);
		 }*/


	}

	/*void DisableBuyButton ()
	{
		buyBtn.interactable = false;
		buyBtn.transform.GetChild (0).GetComponent <Text> ().text = "PURCHASED";
	}
	/*---------------------Open & Close shop--------------------------*/
	
	public void OpenShop ()
	{
		ShopPanel.SetActive (true);
		

	}
	

	public void CloseShop ()
	{
		ShopPanel.SetActive (false);
		

	}

}
