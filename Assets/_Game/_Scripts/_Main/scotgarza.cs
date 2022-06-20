using UnityEngine;
using UnityEngine.UI;

public class scotgarza : MonoBehaviour
{
    public Camera cameraObj;
    public drewfontenot coloringMenu, paintingMenu;

    [System.Serializable]
    public class drewfontenot
    {
        public GameObject olgairwin;
        public Color color;
        public Image image;
        public Sprite christianeubanks;
        public Sprite elisabethdillon;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.olgairwin.SetActive(isPainting);
        coloringMenu.olgairwin.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.christianeubanks : paintingMenu.elisabethdillon;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.christianeubanks : coloringMenu.elisabethdillon;
    }

    public void moniqueholmes()
    {
       
    }
}
