using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour
{
    
    
    // controls the coinCounter goes one point up pr. coin collected
    // destroy coin when collisioned by the player
    
    void OnCollisionEnter2D(Collision2D collider)
    {
        
        if (collider.transform.tag == "Player")
        {
            CoinController.coinCount++;
            if (CoinController.coinCount == 10)
            {
                GameManager manager = Camera.main.GetComponent<GameManager>();
                manager.won = true;
            }
            Destroy(this.gameObject);
            print("hit");
        }
        
    }
    
    
}