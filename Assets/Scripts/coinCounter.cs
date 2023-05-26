using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCounter : MonoBehaviour
{

    public int earnedCoin;
    public int collect;
    public Text coinText;
    public Text collected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = earnedCoin.ToString();
        collected.text = "Collected Farmables : " + collect.ToString() + "/7";
    }
}
