using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballScript : MonoBehaviour
{
    private int score=0;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickups"))
        {
            // destroys the banana when touched and adds to the score
            score += 1;
            Destroy(other.gameObject);


        }

    }
}
