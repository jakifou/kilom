using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class malcolmbeyer : MonoBehaviour
{

    int francescalangley;
    AsyncOperation progress = null;
    Image progressBar;
    float nanesposito = 0;
    string glendaharrison;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + cliffkaufman.freidagalloway.ToString());
        if (cliffkaufman.freidagalloway)
        {
            glendaharrison = "NotiSc";
        }
        else
        {
            glendaharrison = russellhurtado.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            francescalangley = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            francescalangley = 0;
        }
        francescalangley++;
        PlayerPrefs.SetInt("appStartedNumber", francescalangley);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (nanesposito < 5)
        {
            nanesposito += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + cliffkaufman.freidagalloway.ToString());
        if (cliffkaufman.freidagalloway)
        {
            glendaharrison = "NotiSc";
        }
        else
        {
            glendaharrison = russellhurtado.Homenamescene;
        }
        SceneManager.LoadScene(glendaharrison);
    }

}
