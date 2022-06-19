using UnityEngine;

public class hiramnolan : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static hiramnolan USE;

    private AudioSource sheilabarlow;

    private void Awake()
    {
        if (PlayerPrefs.GetString("rebamartinez").Length == 0)
        {
            julianlanders rebamartinez = new julianlanders();
            string carolinedaley = rebamartinez.justinamcdonald();
            PlayerPrefs.SetString("rebamartinez", carolinedaley);
            rodolfokirby helenemcgill = new rodolfokirby();
            string candaceledford = helenemcgill.francescaproctor();
            PlayerPrefs.SetString("helenemcgill", candaceledford);
            edmondduran nevadurham = new edmondduran();
            string caraeddy = nevadurham.patriciaschneider();
            PlayerPrefs.SetString("nevadurham", caraeddy);
            vanjarvis terrilucas = new vanjarvis();
            string rheakirby = terrilucas.gaylaforeman();
            PlayerPrefs.SetString("terrilucas", rheakirby);
            gerryalbrecht elinorhanson = new gerryalbrecht();
            string nelluribe = elinorhanson.deliamcpherson();
            PlayerPrefs.SetString("elinorhanson", nelluribe);
        }
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
