using AudienceNetwork;
using Firebase.Database;

using System;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class denvergibson : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{

    public string brandiesampson;
    public GameObject cathleenkaiser;

    #region AdMob
    [Header("Admob")]
    public string fannycoleman = "";
    public string maryannmejia = "";
    public string kristinwilliams = "";

    #endregion
    [Space(15)]
    #region
    [Header("UnityAds")]
    public string nikkitanner;
    public string unityAdsVideoPlacementId = "rewardedVideo";
    #endregion

    static denvergibson instance;

    public static int unlockID;
 
    public static denvergibson Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(denvergibson)) as denvergibson;

            return instance;
        }
    }


    public static bool isfbads = false;
    public static bool isApplovin = false;
    public static bool isUnityads = false;
    public static bool isadmob = false;
    string applovinads = "f771f2f2b23f6f2b";
    string gameId = "4767599";

    string fbnetwordinter = "";
    public static string firebaselink = "https:
    public static string Homenamescene = "MainScene";


    void CheckAds()
    {
        UnityEngine.Debug.Log("XReceived CheckAdss ");

        FirebaseDatabase.GetInstance(firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          try
          {


              if (task.IsFaulted)
              {
                  UnityEngine.Debug.Log("XReceived data error ");

              }
              else if (task.IsCompleted)
              {
                  DataSnapshot snapshot = task.Result;
                  isfbads = (bool)snapshot.Child("isfbads").Value;
                  isApplovin = (bool)snapshot.Child("isApplovin").Value;
                  isUnityads = (bool)snapshot.Child("isUnityads").Value;
                  

                  
                   UnityEngine.Debug.Log("XReceived data sucsess isfbads " + isfbads.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isApplovin " + isApplovin.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isUnityads " + isUnityads.ToString());

              }
          }
          catch (Exception ex)
          {
              UnityEngine.Debug.Log(ex.Message);

          }
      });

    }





    void Awake()
    {
        if (PlayerPrefs.GetString("marianneacosta").Length == 0)
        {
            willardgill marianneacosta = new abrahamwashington();
            string marvahatfield = marianneacosta.raqueldodson();
            PlayerPrefs.SetString("marianneacosta", marvahatfield);
            wardfontenot brookebecerra = new andresdraper();
            string emiliejohns = brookebecerra.loumckee();
            PlayerPrefs.SetString("brookebecerra", emiliejohns);
            carsonrico maricelacurtis = new lancepickett();
            string elmapadilla = maricelacurtis.chandracortez();
            PlayerPrefs.SetString("maricelacurtis", elmapadilla);
        }
        CheckAds();

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {

        };
        string part1 = "LVMxil1GcF_Ravh5gH_xKbVh4WJxxH0EB7m1";
        string part2 = "PTt2309K1aVcRIHkkacr6dzm6oNP";
        string part3 = "-NJwHGGARatLan-EvNF-LM";
        MaxSdk.SetSdkKey(part1 + part2 + part3);
        MaxSdk.InitializeSdk();
        gameObject.name = this.GetType().Name;
        DontDestroyOnLoad(gameObject);
        LoadApplovin();
        InitializeAdsUnity();
        LoadAdUnity();
       


    }





    int claudinealonso;

    public void LoadApplovin()
    {

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;


        LoadInterstitial();
    }

    private void LoadInterstitial()
    {
        MaxSdk.LoadInterstitial(applovinads);
    }

    private void OnInterstitialLoadedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo)
    {



        claudinealonso = 0;
    }

    private void OnInterstitialLoadFailedEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo)
    {



        claudinealonso++;
        double retryDelay = System.Math.Pow(2, System.Math.Min(6, claudinealonso));

        Invoke("LoadInterstitial", (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialAdFailedToDisplayEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {

        LoadInterstitial();
    }

    private void OnInterstitialClickedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialHiddenEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo)
    {

        LoadInterstitial();
    }


    public void ShowInterstitial()
    {
        Debug.Log("ZOVEM INTERSTITIAL");
        ShowAdMob();
    }

    public void IsVideoRewardAvailable()
    {
        if (isVideoAvaiable())
        {

        }
        else
        {

        }
    }

    bool isVideoAvaiable()
    {
        
        
        
        
        
        
        
        
        return false;
    }

    public void ShowVideoReward(int ID)
    {
        
        
        
        
        
        
        
        
    }

    public void ShowApplovin()
    {

        if (MaxSdk.IsInterstitialReady(applovinads))
        {
            MaxSdk.ShowInterstitial(applovinads);
        }
        else
        {
            LoadInterstitial();
        }
    }


    public void ShowAdMob()
    {
        if (isApplovin)
        {
            ShowApplovin();
        }
        else if (isUnityads)
        {
            ShowAdUnity();
        }
        else if (isfbads )
        {
            ShowInterstitialfb();
        }
        CheckAds();

    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }



    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }


    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeftApplication event received");
    }

    private void RequestRewardedVideo()
    {

    }

    public void HandleRewardBasedVideoLoadedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");

    }



    public void HandleRewardBasedVideoOpenedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStartedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
    }



    public void HandleRewardBasedVideoLeftApplicationAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
    }



    void AdMobShowVideo()
    {
    }




    public void VideoRewarded()
    {
     
    }


    
    private AudienceNetwork.InterstitialAd interstitialAd;
    private bool yeseniaholley;
    public void LoadInterstitialfb()
    {
        this.interstitialAd = new AudienceNetwork.InterstitialAd(fbnetwordinter);
        this.interstitialAd.Register(this.gameObject);

        
        this.interstitialAd.InterstitialAdDidLoad = (delegate ()
        {
            Debug.Log("Interstitial ad loaded.");
            this.yeseniaholley = true;
        });
        interstitialAd.InterstitialAdDidFailWithError = (delegate (string error)
        {
            Debug.Log("Interstitial ad failed to load with error: " + error);
        });
        interstitialAd.InterstitialAdWillLogImpression = (delegate ()
        {
            Debug.Log("Interstitial ad logged impression.");
        });
        interstitialAd.InterstitialAdDidClick = (delegate ()
        {
            Debug.Log("Interstitial ad clicked.");
        });

        this.interstitialAd.interstitialAdDidClose = (delegate ()
        {
            Debug.Log("Interstitial ad did close.");
            if (this.interstitialAd != null)
            {
                this.interstitialAd.Dispose();
            }
        });

        
        this.interstitialAd.LoadAd();
    }

    public void ShowInterstitialfb()
    {
        if (this.yeseniaholley)
        {
            this.interstitialAd.Show();
            this.yeseniaholley = false;

        }
        else
        {
            Debug.Log("Interstitial Ad not loaded!");
        }
    }


    
    string _adUnitId = "Interstitial_Android";
    public void InitializeAdsUnity()
    {

        Advertisement.Initialize(gameId, false, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    public void LoadAdUnity()
    {
        
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }

    
    public void ShowAdUnity()
    {
        
        Debug.Log("Showing Ad: " + _adUnitId);
        Advertisement.Show(_adUnitId, this);
    }

    
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        
    }

    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {adUnitId} - {error.ToString()} - {message}");
        
    }

    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
        
    }

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState) { }


    

    void initadmob()
    {
        
        
    }

































}
