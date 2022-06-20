using UnityEngine;

public class antoniomichael : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static antoniomichael USE;

    private AudioSource lupepollard;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            lupepollard = transform.GetChild(0).GetComponent<AudioSource>();

            ivatalley();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void ivatalley()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void reginapierson()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void michaelshafer(AudioClip clip)
    {
        lupepollard.PlayOneShot(clip);
    }
}
