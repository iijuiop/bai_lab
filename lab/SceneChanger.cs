using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string nextSceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {   
            Time.timeScale = 1f;
            SceneManager.LoadScene(nextSceneName);
        }
    }
}