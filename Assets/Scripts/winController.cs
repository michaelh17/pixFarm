using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winController : MonoBehaviour
{

    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPanel()
    {
        win.SetActive(true);
    }


    public void playAgain()
    {
        win.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backTo()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
