using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class santiagowinston : MonoBehaviour
{
    private static string heatherdonahue = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string johnniecantrell;

    
    public static void elinortapia()
    {
        string prefix = PlayerPrefs.GetString(heatherdonahue, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        johnniecantrell = PlayerPrefs.GetString(heatherdonahue, "");
        urlPrefixInput.text = johnniecantrell;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        johnniecantrell = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(heatherdonahue, johnniecantrell);
        AudienceNetwork.AdSettings.SetUrlPrefix(johnniecantrell);
    }

    public void AdViewScene()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void InterstitialAdScene()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void RewardedVideoAdScene()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
