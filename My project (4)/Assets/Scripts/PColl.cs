using UnityEngine;

public class PColl : MonoBehaviour
{
    public PlayerMove Movement;
    public GM gm;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Wall")
        {
            Movement.enabled = false;
            FindObjectOfType<GM>().EndGame();
        }
    }

}
