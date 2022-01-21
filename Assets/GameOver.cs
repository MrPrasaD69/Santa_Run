using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject PlayerDisabled;
    public void GameOverMenu()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        
    }
    
    
    
    
}
