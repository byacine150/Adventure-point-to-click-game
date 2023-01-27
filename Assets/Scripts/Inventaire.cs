using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventaire : MonoBehaviour
{
    [SerializeField] private GameObject zoneAffichage;

    [SerializeField] private Button leBouton;


    void Start()
    {
    }
    public void ActionnerBouton()
    {
        if (zoneAffichage.activeSelf)
        {
            zoneAffichage.SetActive(false);
            GameObject.Find("ToggleZoneAffichage").GetComponentInChildren<Text>().text = "Fermer l'inventaire";
            // GetComponentInChildren<Text>().text = "Cacher";
        }


        else
        {
            zoneAffichage.SetActive(true);
            GameObject.Find("ToggleZoneAffichage").GetComponentInChildren<Text>().text = "Ouvrir l'inventaire";
            // GetComponentInChildren<Text>().text = "Afficher";
        }

    }

}
