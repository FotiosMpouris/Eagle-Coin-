using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    
    // Update is called once per frame
    void Start ()
    {
        Time.timeScale = 0.7f;
    }
    
    
           
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            Time.timeScale = 0.5f;
            gameOverPanel.SetActive(true);   
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        
    }
}
