using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void Start()
    {
        
        SceneManager.LoadScene("End", LoadSceneMode.Single);
    }
}