using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;

    private void Awake()
    {
        int gameSessionCount = FindObjectsOfType<GameSession>().Length;

        if (gameSessionCount > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void ProcessPlayerHit()
    {
        TakeLife();
    }

    private void TakeLife()
    {
        this.playerLives--;
        //var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentSceneIndex);
    }
    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(this.gameObject);
    }
}
