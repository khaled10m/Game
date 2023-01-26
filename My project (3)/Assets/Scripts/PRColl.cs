using UnityEngine;

public class PRColl : MonoBehaviour
{
    public PRM Movement;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Wall")
        {
            Movement.enabled = false;
            FindObjectOfType<GM>().EndGame();
        }
    }

}
