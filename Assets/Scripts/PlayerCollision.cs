using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PlayerCollision : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject ctrlScript;
    public GameObject BgMusic;

    void OnCollisionEnter2D(Collision2D collision)
        
    {
        if(collision.gameObject.tag == "Player" )
        {
            if(transform.position.y < -9.5)
                
            Debug.Log("Game Over!!");
            restartMenu.SetActive(true);
            

        }
        
        
    }


}
