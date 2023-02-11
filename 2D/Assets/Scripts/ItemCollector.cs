using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruits = 0;
    [SerializeField] private Text Ptext;
    [SerializeField] private AudioSource CollectSE;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            CollectSE.Play();
            Destroy(collision.gameObject);
            fruits++;
            Ptext.text = "Pineapples: " + fruits;
        }
    }
}
