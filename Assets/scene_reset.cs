using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_reset : MonoBehaviour
{
    void Start()
    {
        // Did not test the script. If it doesn't work, Google is a friend!
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }
}