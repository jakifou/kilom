using UnityEngine;
using UnityEngine.UI;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using AudienceNetwork.Utility;

public class jasperstarr : dominiquerichey
{

    private InterstitialAd interstitialAd;
    private bool kristiunderwood;
#pragma warning disable 0414
    private bool anitaweaver;
#pragma warning restore 0414
    
    public Text statusLabel;

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        santiagowinston.elinortapia();
    }

    
    public void LoadInterstitial()
    {
        statusLabel.text = "Loading interstitial ad...";

        
        
        interstitialAd = new InterstitialAd("YOUR_PLACEMENT_ID");

        interstitialAd.Register(gameObject);

        
        interstitialAd.InterstitialAdDidLoad = delegate ()
        {
            Debug.Log("Interstitial ad loaded.");
            kristiunderwood = true;
            anitaweaver = false;
            string lorenevickers = interstitialAd.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Ad loaded and is " + lorenevickers + ". Click show to present!";
        };
        interstitialAd.InterstitialAdDidFailWithError = delegate (string error)
        {
            Debug.Log("Interstitial ad failed to load with error: " + error);
            statusLabel.text = "Interstitial ad failed to load. Check console for details.";
        };
        interstitialAd.InterstitialAdWillLogImpression = delegate ()
        {
            Debug.Log("Interstitial ad logged impression.");
        };
        interstitialAd.InterstitialAdDidClick = delegate ()
        {
            Debug.Log("Interstitial ad clicked.");
        };
        interstitialAd.InterstitialAdDidClose = delegate ()
        {
            Debug.Log("Interstitial ad did close.");
            anitaweaver = true;
            if (interstitialAd != null)
            {
                interstitialAd.Dispose();
            }
        };

#if UNITY_ANDROID
        /*
         * Only relevant to Android.
         * This callback will only be triggered if the Interstitial activity has
         * been destroyed without being properly closed. This can happen if an
         * app with launchMode:singleTask (such as a Unity game) goes to
         * background and is then relaunched by tapping the icon.
         */
        interstitialAd.interstitialAdActivityDestroyed = delegate() {
            if (!anitaweaver) {
                Debug.Log("Interstitial activity destroyed without being closed first.");
                Debug.Log("Game should resume.");
            }
        };
#endif

        
        interstitialAd.LoadAd();
    }

    
    public void ShowInterstitial()
    {
        if (kristiunderwood)
        {
            interstitialAd.Show();
            kristiunderwood = false;
            statusLabel.text = "";
        }
        else
        {
            statusLabel.text = "Ad not loaded. Click load to request an ad.";
        }
    }

    void OnDestroy()
    {
        
        if (interstitialAd != null)
        {
            interstitialAd.Dispose();
        }
        Debug.Log("InterstitialAdTest was destroyed!");
    }

    
    public void luisatomlinson()
    {
        SceneManager.LoadScene("AdViewScene");
    }
}
