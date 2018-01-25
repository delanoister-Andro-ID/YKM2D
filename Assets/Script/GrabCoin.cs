using UnityEngine;
using System.Collections;

public class GrabCoin : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "AnakMasjid")
        {
            Destroy(gameObject.GetComponent<Collider2D>());
            gameObject.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject, 0.47f);
        }
    }
}