using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationP : MonoBehaviour
{

	[System.Serializable]
	public class ShopItem
	{
		public Sprite Image;
		public int Price;
		public bool IsPurchased = false;
	}

	public List<ShopItem> ShopItemsList;


	private Animator anim;
	[SerializeField] GameObject ItemTemplate;
	GameObject g;
	[SerializeField] Transform ShopScrollView;
	[SerializeField] GameObject ShopPanel;

	Button buyBtn, SelectBtn;

	public Move Movement;
	void Start()
	{
		anim = GetComponent<Animator>();
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
			

			SelectBtn.AddEventListener(i, OnItemClicked);

			
		}
	}

	public void makeAnimation()
	{
		anim.Play("ShopAnimation2");
	}
	public void ClosePanel()
	{
		anim.Play("ClosePanel2");
	}

	void OnItemClicked(int itemIndex)
	{
		Debug.Log("button clicked");
		if(ButtonManager.Animation)
        {
			Movement.Movement1(itemIndex);
		}
		/*if (ButtonManager.Glasses)
		{
			ChangeGlasses.ChangeMaterial(itemIndex);
		}
		else if (ButtonManager.Shoes)
		{
			ChangeShoes.ChangeMaterial(itemIndex);
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
		else
		{
			//
		}
		*/

	}

	
	/*---------------------Open & Close shop--------------------------*/
	public void OpenShop()
	{
		ShopPanel.SetActive(true);


	}


	public void CloseShop()
	{
		ShopPanel.SetActive(false);


	}
}
