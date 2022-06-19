using UnityEngine;
using UnityEngine.SceneManagement;

public class jaysonvogel : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void tonimetzger()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
