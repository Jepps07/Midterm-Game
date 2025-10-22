using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public partial class CoinScript : MonoBehaviour
{
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        //This destroys the coin
        {
            // Move the coin to a new random position instead of destroying it
            transform.position = GetRandomPosition();
        }

        Vector2 GetRandomPosition()
        {
            float x = UnityEngine.Random.Range(-8f, 8f);
            float y = UnityEngine.Random.Range(-4f, 4f);
            return new Vector2(x, y);
        }
    }
}
