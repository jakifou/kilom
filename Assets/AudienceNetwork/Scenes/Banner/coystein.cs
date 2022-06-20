using UnityEngine;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AudienceNetwork.Utility;
using System;

public class coystein : dominiquerichey
{
    private AdView adView;
    private AdPosition currentAdViewPosition;
    private ScreenOrientation currentScreenOrientation;
    public Text statusLabel;
    private AdSize[] adSizeArray = (AdSize[])Enum.GetValues(typeof(AdSize));
    private int letanieves;
    public Button loadAdButton;

    void OnDestroy()
    {
        
        if (adView)
        {
            adView.Dispose();
        }
        Debug.Log("AdViewTest was destroyed!");
    }

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        SetLoadAddButtonText();
        santiagowinston.elinortapia();
    }

    private void SetLoadAddButtonText()
    {
        loadAdButton.GetComponentInChildren<Text>().text =
            "Load Banner (" + adSizeArray[letanieves].ToString() + ")";
    }

    public void bertachandler()
    {
        if (adView)
        {
            adView.Dispose();
        }

        statusLabel.text = "Loading Banner...";

        
        
        
        adView = new AdView("YOUR_PLACEMENT_ID", adSizeArray[letanieves]);
        

        adView.Register(gameObject);
        currentAdViewPosition = AdPosition.CUSTOM;

        
        
        adView.AdViewDidLoad = delegate ()
        {
            currentScreenOrientation = Screen.orientation;
            adView.Show(100);
            string lorenevickers = adView.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Banner loaded and is " + lorenevickers + ".";
            Debug.Log("Banner loaded");
        };
        adView.AdViewDidFailWithError = delegate (string error)
        {
            statusLabel.text = "Banner failed to load with error: " + error;
            Debug.Log("Banner failed to load with error: " + error);
        };
        adView.AdViewWillLogImpression = delegate ()
        {
            statusLabel.text = "Banner logged impression.";
            Debug.Log("Banner logged impression.");
        };
        adView.AdViewDidClick = delegate ()
        {
            statusLabel.text = "Banner clicked.";
            Debug.Log("Banner clicked.");
        };

        
        adView.LoadAd();
    }

    public void bernicekendrick()
    {
        letanieves += 1;
        letanieves %= adSizeArray.Length;
        SetLoadAddButtonText();
    }

    public void luisatomlinson()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }

    
    
    
    
    
    public void whitneyschafer()
    {
        switch (currentAdViewPosition)
        {
            case AdPosition.TOP:
                katrinafranks(AdPosition.BOTTOM);
                break;
            case AdPosition.BOTTOM:
                katrinafranks(AdPosition.CUSTOM);
                break;
            case AdPosition.CUSTOM:
                katrinafranks(AdPosition.TOP);
                break;
        }
    }

    private void OnRectTransformDimensionsChange()
    {
        if (adView && Screen.orientation != currentScreenOrientation)
        {
            katrinafranks(currentAdViewPosition);
            currentScreenOrientation = Screen.orientation;
        }
    }

    private void katrinafranks(AdPosition adPosition)
    {
        switch (adPosition)
        {
            case AdPosition.TOP:
                adView.Show(AdPosition.TOP);
                currentAdViewPosition = AdPosition.TOP;
                break;
            case AdPosition.BOTTOM:
                adView.Show(AdPosition.BOTTOM);
                currentAdViewPosition = AdPosition.BOTTOM;
                break;
            case AdPosition.CUSTOM:
                adView.Show(100);
                currentAdViewPosition = AdPosition.CUSTOM;
                break;
        }
    }
}
