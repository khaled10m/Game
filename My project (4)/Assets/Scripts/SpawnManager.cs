using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    


   // public Transform Player;
   // public GameObject blockB;
   // public float spawnZ = 0f;
   // private float BLen = 100f;
   // private int nbis = 5;
    RoadSpawner roadSpawner;
    void Start()
    {
        
       // for (int i = 0; i < nbis; i++)
       // {
       //     SpawnB();
      //  }
         roadSpawner = GetComponent<RoadSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (Player.position.z > spawnZ - (nbis * BLen))
       // {
        //    SpawnB();
       // }
    }
    public void STE()
    {
        roadSpawner.MoveRoad();
    }
  // private void SpawnB()
    //{
      //  GameObject go = Instantiate(blockB) as GameObject;
      //  go.transform.SetParent(transform);
      //  go.transform.position = Vector3.forward * spawnZ;
      //  spawnZ += BLen;
   // }
}
