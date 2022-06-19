using UnityEngine;
using UnityEngine.UI;

public class darrellbrandon : MonoBehaviour
{
    public Camera cameraObj;
    public lukebauer coloringMenu, paintingMenu;

    [System.Serializable]
    public class lukebauer
    {
        public GameObject vanessagustafson;
        public Color color;
        public Image image;
        public Sprite robertdempsey;
        public Sprite autumnsumner;
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

        paintingMenu.vanessagustafson.SetActive(isPainting);
        coloringMenu.vanessagustafson.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.robertdempsey : paintingMenu.autumnsumner;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.robertdempsey : coloringMenu.autumnsumner;
    }

    public void franciscamolina()
    {
       
    }
}
