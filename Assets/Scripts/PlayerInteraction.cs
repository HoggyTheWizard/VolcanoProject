using System;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float speed; 
    private void Update()
    {
        if (Input.GetKey("a") && transform.position.x > -8)
        {
            transform.position += speed * Time.deltaTime * new Vector3(-1f, 0f, 0f); 
        }

        else if (Input.GetKey("d") && transform.position.x < 8)
        {
            transform.position += speed * Time.deltaTime * new Vector3(1f, 0f, 0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"Collided with {col.gameObject.name}"); 
    }
}
