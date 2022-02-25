using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void Start()
    {
        // Did not test the script. If it doesn't work, Google is a friend!
        SceneManager.LoadScene("End", LoadSceneMode.Single);
    }
}