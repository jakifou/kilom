using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class brockdale : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool jenniferberg = false;




    void Update()
    {
        if (kristinaochoa.Length > 0 && !jenniferberg)
        {
            jenniferberg = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + georgettebecker);

            if (georgettebecker.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(ilenecartwright(candyclements, image));
                return;
            }
            else if (tanishatang.Length > 0)
            {
                denvergibson.Instance.ShowApplovin();
            }
            else if (irissuarez.Length > 0)
            {
                denvergibson.Instance.ShowInterstitialfb();
            }
            else if (deidrathacker.Length > 0)
            {
                denvergibson.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(denvergibson.Homenamescene);

        }
    }

    string irissuarez = "";
    string candyclements = "";
    string tanishatang = "";
    string deidrathacker = "";
    string georgettebecker = "";
    string kristinaochoa = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(denvergibson.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              irissuarez = snapshot.Child("NotiFbads").Value.ToString();
              candyclements = snapshot.Child("NotiImg").Value.ToString();
              tanishatang = snapshot.Child("NotiLovin").Value.ToString();
              deidrathacker = snapshot.Child("NotiUnityads").Value.ToString();
              deidrathacker = snapshot.Child("NotiUnityads").Value.ToString();
              georgettebecker = snapshot.Child("NotiUrl").Value.ToString();
              kristinaochoa = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived candyclements " + candyclements);
              UnityEngine.Debug.Log("XReceived georgettebecker " + georgettebecker);

          }
      });

    }

    public void luisakim()
    {
        Application.OpenURL(georgettebecker);

    }

    UnityWebRequest www;
    IEnumerator ilenecartwright(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
