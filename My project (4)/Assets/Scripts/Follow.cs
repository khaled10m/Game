using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Vector3 cam;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cam;
    }
}
