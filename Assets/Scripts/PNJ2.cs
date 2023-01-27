using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PNJ2 : MonoBehaviour
{
    [SerializeField] private Button bouton;
    [SerializeField] private GameObject panneau;
    [SerializeField] Text text;
    private string Message;
    public InventoryManager a;
    bool message1 = true;
    [SerializeField]  GameObject cube;
    void Start()
    {
        bouton = GameObject.Find("Panel").GetComponent<Button>();

        panneau.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        a = FindObjectOfType<InventoryManager>();
        panneau.SetActive(true);
        if (a.listLenght == 1 && message1)
        {
            Message = "Alors comme ça vous m'apportez ce coffre au trésor pour que je vous aide à retourner chez vous. Je prendrais le trésor avec plaisir. Mais avant de vous aider," +
                   "j'aimerais que vous me rendiez un petit service. Je me demandais si avec votre étrange bâton que vous tenez à votre main vous ne pourriez pas vous débarasser de l'ours" +
                   "qui fait peur au habitant de ma tribu. Si cela est possible, j'aimerais bien que vous me rammeniez l'ours, je sens qu'il fera un excellent repas.";
            a.Items.RemoveAt(0);
            message1 = false;
        }
        if (a.listLenght == 0)
        {
            Message = "Partez, je n'ai rien à vous dire !";
            a.Items.RemoveAt(0);
            message1 = false;
        }
        if (a.listLenght == 1 && !message1)
        {
            Message = "Merci de m'avoir rammené l'ours. Moi et ma tribu te remmercions pour nous avoir attrapé notre repas de ce soir. Miam, j'en ai déja l'eau à la bouche. " +
                 "Pour retourner chez toi, tu n'as qu'à traverser le chateau qui se trouve à l'arrière de notre village. Pendant que tu étais en train d'ammener l'ours, j'ai préparé une" +
                 "incantation qui te permettra de retrouver tes proches. À la prochaine !";
            a.Items.RemoveAt(0);

            Destroy(cube);

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
