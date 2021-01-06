using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene(2);
    }

    public void HowScene()
    {
        SceneManager.LoadScene(1);
    }
}
