using UnityEngine;

using UnityEngine.UI;



public class Score : MonoBehaviour

{
    int x = 0;
    public Transform player;

    public Text scoreText;



    void Update()

    {

        scoreText.text = (player.position.z + x).ToString("0");

    }
}