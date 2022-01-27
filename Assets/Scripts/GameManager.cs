using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;

    public void EndGame()
    {
        if (hasEnded)
            return;
        StartCoroutine(PlayEndGameAnimation());
    }

    IEnumerator PlayEndGameAnimation()
    {
        Debug.Log("GAME OVER!");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
