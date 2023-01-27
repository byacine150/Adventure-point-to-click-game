using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texting : MonoBehaviour
{

    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "Allo";
        _text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
