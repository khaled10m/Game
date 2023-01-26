using UnityEngine;

using UnityEngine.UI;



public class Score : MonoBehaviour

{
    int x = -10;
    public Transform player;

    public Text scoreText;



    void Update()

    {

        scoreText.text = (player.position.z+x).ToString("0");

    }
}