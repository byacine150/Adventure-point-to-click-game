using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;

    public GameObject InventoryItem;

    public int listLenght;

    void Update()
    {
       ListItems();
        listLenght = Items.Count;
        //  Debug.Log(listLenght);
       
    }

    
       
    

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);

    }


     void ListItems()
    {
        foreach (Transform item in ItemContent)
        {

            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {

            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

           itemIcon.sprite = item.icon;
          
        }
    }
}
