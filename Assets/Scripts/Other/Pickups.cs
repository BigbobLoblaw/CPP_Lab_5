using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Pickups : MonoBehaviour
{
    public enum CollectibleType
    {
        POWERUP,
        COLLECTIBLE,
        LIVES,
        KEY
    }

    public CollectibleType currentCollectible;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Mario")
        {
            switch (currentCollectible)
            {
                case CollectibleType.POWERUP:
                    Debug.Log("PowerUp");
                    collision.GetComponent<PlayerMovement>().StartJumpForceChange();
                    Destroy(this.gameObject);
                    break;
                case CollectibleType.COLLECTIBLE:
                    Debug.Log("Collectible");
                    collision.GetComponent<PlayerMovement>().score++;
                    Destroy(this.gameObject);
                    break;
                case CollectibleType.LIVES:
                    Debug.Log("Lives");
                    collision.GetComponent<PlayerMovement>().lives++;
                    Destroy(this.gameObject);

                    break;
                
            } 
        }
    }
}
