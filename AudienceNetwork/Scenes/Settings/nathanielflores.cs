using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class malcolmbarrios : MonoBehaviour
{
    private static string jeniferschultz = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string bettielight;

    
    public static void raeakins()
    {
        string prefix = PlayerPrefs.GetString(jeniferschultz, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        bettielight = PlayerPrefs.GetString(jeniferschultz, "");
        urlPrefixInput.text = bettielight;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        bettielight = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(jeniferschultz, bettielight);
        AudienceNetwork.AdSettings.SetUrlPrefix(bettielight);
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
