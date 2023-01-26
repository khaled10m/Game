using UnityEngine;
using UnityEngine.SceneManagement;
public class GM : MonoBehaviour
{
    bool GameOver = false;
    public GameObject complevui;
    public void Complete()
    {
        complevui.SetActive(true);
    }
    public void EndGame()
    {
        if (GameOver == false)
        {
            GameOver = true;
            Restart();
        } 
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
