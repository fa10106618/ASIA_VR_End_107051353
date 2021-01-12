
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("VR");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
