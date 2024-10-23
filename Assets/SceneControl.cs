using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string scenecName)
    {
        SceneManager.LoadScene(scenecName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
