using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PNJ1 : MonoBehaviour
{
    [SerializeField] private Button bouton;
    [SerializeField] private GameObject panneau;
    [SerializeField]  Text text;
    private string Message;
   public InventoryManager a;
    bool message1 = true;
    void Start()
    {
        bouton = GameObject.Find("Panel").GetComponent<Button>();

        panneau.SetActive(false);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        a = FindObjectOfType<InventoryManager>();
        panneau.SetActive(true);
      if (a.listLenght == 0 && message1)
      {
         Message = "Tiens tiens tiens, alors comme �a vous voulez mon aide pour retourner chez vous ??? Ce ne sera pas si facile que cela mon ami. " +
                "Il va falloir que m'aidiez d'abbord puis apr�s, nous discuterons. En rentrant de chez moi, apr�s une rude journ�e pass� � la mine d'or, j'ai" +
                "oubli� dans quel endroit j'ai mis ma pr�cieuse dynamite porte bonheur. Si vous pouviez la r�cup�rer pour moi, je songerais � vous aider.";
      
      }
        
        if (a.listLenght == 1)
       {
           Message = "Oh mille mercis, vous avez r�cup�r� ma pr�cieuse dynamite. Viens par la mon pr�cieux, je ne te perderais plus. Merci l'ami, comme je vous l'ai" +
                "promis, je vais maintenant vous aider. Il y a une ile qui se trouve dans la direction vers laquelle le train pointe. Sur cette �le, il vous sera" +
                "possible de r�cup�rer une coffre au tr�sor que vous devrez donnez au shaman du village indien. Ce village se trouve de l'autre c�t� de la rivi�re." +
                "Il vous suffit de traverser le pont et de donner au shaman le coffre et il vous rammenera chez vous.";
            a.Items.RemoveAt(0);

            message1 = false;

        }

        text.text = Message;
       
        
      

    }

  
    public void CacherAfficherPanneau()
    {
       



        bool visible = panneau.activeSelf;
        visible = !visible;
        panneau.SetActive(visible);

        Destroy(bouton);
    }





}
