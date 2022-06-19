using UnityEngine;

public class hiramnolan : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static hiramnolan USE;

    private AudioSource sheilabarlow;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            sheilabarlow = transform.GetChild(0).GetComponent<AudioSource>();

            karinaswenson();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void karinaswenson()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void serenacurtis()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void nikkigregg(AudioClip clip)
    {
        sheilabarlow.PlayOneShot(clip);
    }
}
