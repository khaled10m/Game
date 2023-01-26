using UnityEngine;
using UnityEngine.SceneManagement;
public class lvlc : MonoBehaviour
{
    public void Loadlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
