using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signController : MonoBehaviour
{
    public Text show;
    public GameObject show2;
    private bool isRead;
    
    // Start is called before the first frame update
    void Start()
    {
        show.gameObject.SetActive(false);
        show2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isRead && Input.GetKeyDown(KeyCode.E))
        {
            show.gameObject.SetActive(false);
            showBoard();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            show2.gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            show.gameObject.SetActive(true);
            isRead = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            show.gameObject.SetActive(false);
            isRead = false;
        }
    }

    private void showBoard()
    {
        show2.gameObject.SetActive(true);
    }



}
