using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class owenhurt : MonoBehaviour
{

    int hallieschmitz;
    AsyncOperation progress = null;
    Image progressBar;
    float estellarandolph = 0;
    string lesliepolk;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + brettgrace.ilalindsey.ToString());
        if (brettgrace.ilalindsey)
        {
            lesliepolk = "NotiSc";
        }
        else
        {
            lesliepolk = denvergibson.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            hallieschmitz = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            hallieschmitz = 0;
        }
        hallieschmitz++;
        PlayerPrefs.SetInt("appStartedNumber", hallieschmitz);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (estellarandolph < 5)
        {
            estellarandolph += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + brettgrace.ilalindsey.ToString());
        if (brettgrace.ilalindsey)
        {
            lesliepolk = "NotiSc";
        }
        else
        {
            lesliepolk = denvergibson.Homenamescene;
        }
        SceneManager.LoadScene(lesliepolk);
    }

}
