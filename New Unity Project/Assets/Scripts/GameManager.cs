using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
    public float endDelay = 1f;

    public void completeLevel()
    {
        Debug.Log("won");
    }
    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Invoke("Restart", endDelay); //invoke calls a delay before method is called
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
