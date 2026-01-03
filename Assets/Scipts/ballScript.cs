using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballScript : MonoBehaviour
{
    public AudioSource source;
    private int score=0;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickups"))
        {
            // destroys the banana when touched,plays a sound effect and adds to the score
            score += 1;
            source.Play();
            Destroy(other.gameObject);
        }

    }
}
