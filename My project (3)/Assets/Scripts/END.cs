using UnityEngine;

public class END : MonoBehaviour
{
    public GM gm;
     void OnTriggerEnter()
    {
        gm.Complete();
    }
}
