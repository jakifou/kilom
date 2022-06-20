using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class carmenelkins : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool naomijuarez = false;




    void Update()
    {
        if (maralancaster.Length > 0 && !naomijuarez)
        {
            naomijuarez = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + deidremerrill);

            if (deidremerrill.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(ingridfigueroa(gretchenmilligan, image));
                return;
            }
            else if (emiliehorn.Length > 0)
            {
                russellhurtado.Instance.ShowApplovin();
            }
            else if (kristytrent.Length > 0)
            {
                russellhurtado.Instance.ShowInterstitialfb();
            }
            else if (caratucker.Length > 0)
            {
                russellhurtado.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(russellhurtado.Homenamescene);

        }
    }

    string kristytrent = "";
    string gretchenmilligan = "";
    string emiliehorn = "";
    string caratucker = "";
    string deidremerrill = "";
    string maralancaster = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(russellhurtado.firebaselink)
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
              kristytrent = snapshot.Child("NotiFbads").Value.ToString();
              gretchenmilligan = snapshot.Child("NotiImg").Value.ToString();
              emiliehorn = snapshot.Child("NotiLovin").Value.ToString();
              caratucker = snapshot.Child("NotiUnityads").Value.ToString();
              caratucker = snapshot.Child("NotiUnityads").Value.ToString();
              deidremerrill = snapshot.Child("NotiUrl").Value.ToString();
              maralancaster = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived gretchenmilligan " + gretchenmilligan);
              UnityEngine.Debug.Log("XReceived deidremerrill " + deidremerrill);

          }
      });

    }

    public void kaitlyncaldwell()
    {
        Application.OpenURL(deidremerrill);

    }

    UnityWebRequest www;
    IEnumerator ingridfigueroa(string url, Image targetImage)
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
