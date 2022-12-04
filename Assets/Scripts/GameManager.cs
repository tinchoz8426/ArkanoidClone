using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int lifes;
    public AudioSource deathSound;

    public void LostLife()
    {
        //Debug.Log("Persdiste!!");
        lifes--;

        if(lifes <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            ResetLevel();
        }
       
    }

    public void ResetLevel()
    {
        deathSound.Play();
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    public void CheckLevelCompleted()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length <= 1)
        {
            //Debug.Log("Pasaste de level perro!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
