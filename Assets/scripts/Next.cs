using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding object is the player
        {
            SceneManager.LoadScene("level2");
        }
    }
}
