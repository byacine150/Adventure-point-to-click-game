using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Messagededébut : MonoBehaviour
{
    [SerializeField] private Button bouton;
    [SerializeField] private GameObject panneau;
    [SerializeField]  Text text;

    void Start()
    {
      
    }

    public void CacherAfficherPanneau()
    {
        bool visible = panneau.activeSelf;
        visible = !visible;
        panneau.SetActive(visible);

        Destroy(bouton);
    }
}
