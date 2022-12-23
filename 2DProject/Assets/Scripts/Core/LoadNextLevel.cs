using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private int nextToLoad;
    void Start()
    {
        nextToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextToLoad);
    }
}
