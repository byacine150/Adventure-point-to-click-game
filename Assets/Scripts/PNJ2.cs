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
            Message = "Alors comme �a vous m'apportez ce coffre au tr�sor pour que je vous aide � retourner chez vous. Je prendrais le tr�sor avec plaisir. Mais avant de vous aider," +
                   "j'aimerais que vous me rendiez un petit service. Je me demandais si avec votre �trange b�ton que vous tenez � votre main vous ne pourriez pas vous d�barasser de l'ours" +
                   "qui fait peur au habitant de ma tribu. Si cela est possible, j'aimerais bien que vous me rammeniez l'ours, je sens qu'il fera un excellent repas.";
            a.Items.RemoveAt(0);
            message1 = false;
        }
        if (a.listLenght == 0)
        {
            Message = "Partez, je n'ai rien � vous dire !";
            a.Items.RemoveAt(0);
            message1 = false;
        }
        if (a.listLenght == 1 && !message1)
        {
            Message = "Merci de m'avoir rammen� l'ours. Moi et ma tribu te remmercions pour nous avoir attrap� notre repas de ce soir. Miam, j'en ai d�ja l'eau � la bouche. " +
                 "Pour retourner chez toi, tu n'as qu'� traverser le chateau qui se trouve � l'arri�re de notre village. Pendant que tu �tais en train d'ammener l'ours, j'ai pr�par� une" +
                 "incantation qui te permettra de retrouver tes proches. � la prochaine !";
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
