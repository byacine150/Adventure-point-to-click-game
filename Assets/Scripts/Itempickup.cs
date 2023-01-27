using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itempickup : MonoBehaviour
{

    public AudioSource playSound;
    // Start is called before the first frame update
    public Item Item;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
        playSound.Play();

    }

   private void OnMouseDown()
    {
        Pickup();

    }
}
