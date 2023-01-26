using UnityEngine;

public class PRM : MonoBehaviour
{
    public Rigidbody rb;

    public float FF=1000f;
    public float SF = 500f;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, FF*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SF* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SF* Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GM>().EndGame();
        }
    }
}
