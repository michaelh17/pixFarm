using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadController : MonoBehaviour
{
    public GameObject dead;
    
    // Start is called before the first frame update
    void Start()
    {
        dead.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showPanel()
    {
        dead.SetActive(true);
    }


    public void playAgain()
    {
        dead.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backTo()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
