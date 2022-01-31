using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;

    public GameObject gameOverScreenRed;
    public GameObject gameOverScreenBlue;

    void Awake()
    {
        gameOverScreenRed.SetActive(false);
        gameOverScreenBlue.SetActive(false);
    }

    public void EndGame(string playerName)
    {
        if (hasEnded)
            return;
        if (playerName == "blue")
        {
            hasEnded = true;
            gameOverScreenRed.SetActive(false);
            gameOverScreenBlue.SetActive(true);
        }
        else
        {
            hasEnded = true;
            gameOverScreenRed.SetActive(true);
            gameOverScreenBlue.SetActive(false);
        }

        StartCoroutine(PlayEndGameAnimation());
    }

    IEnumerator PlayEndGameAnimation()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
