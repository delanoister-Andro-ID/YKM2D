using UnityEngine;
using System.Collections;

public class Setan : MonoBehaviour
{
    public Vector3 moveSpeed;
    public GameObject alertBridge;

    void Start()
    {
    }
    
    void Update()
    {
        transform.position -= moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "AnakMasjid")
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.name == "AnakMasjid")
        {
            Destroy(other.gameObject.GetComponent<Collider2D>());
            other.gameObject.GetComponent<Renderer>().enabled = false; 
            Destroy(other.gameObject, 0.626f);
            alertBridge.GetComponent<MoveRight>().Alert("gameover");
        }
    }
}