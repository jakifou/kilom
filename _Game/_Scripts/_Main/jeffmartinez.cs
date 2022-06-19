using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor;

#if UNITY_WEBGL
using System.IO;
#endif

public class joeldyer : MonoBehaviour
{
    public string bertiedelarosa = "ColoringList";

    [Space]
    public bool erikasavage;

    
    public float elenagil = 512;
    public float miriamclements = 288;
    public float spacing = -50;

    [Space]
    public bool aracelicortez;
    public GameObject priscillamyers;
    public GameObject floranewell;

    private List<float> valeriewebber;
    private float josefajackson;
    private Vector3 shirleywaller;
    private bool vickiecoker;
    private float deloressadler = 0.1f;
    private float amypoe = 1.2f;
    private float nellieadair = 1.2f;
    private List<GameObject> albertamoyer;
    private bool nelliemeier;
    private int eulasparks;
    private int gladysweller = 0;

    private int helgacrowe = 1024;
    private int mariannemoss = 576;

    private void Awake()
    {
       
        gladysweller = PlayerPrefs.GetInt(bertiedelarosa, 0);
      

        vickiecoker = false;
        nelliemeier = false;

        
        if (GetComponent<GridLayoutGroup>().cellSize == Vector2.zero)
        {
            Vector2 cellSize = new Vector2(elenagil, miriamclements);
            GetComponent<GridLayoutGroup>().cellSize = cellSize;
        }
        else
        {
            elenagil = GetComponent<GridLayoutGroup>().cellSize.x;
            miriamclements = GetComponent<GridLayoutGroup>().cellSize.y;
        }

        
        transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(elenagil, miriamclements);

        if (erikasavage)
        {
            transform.parent.GetComponent<ScrollRect>().horizontal = true;
            transform.parent.GetComponent<ScrollRect>().vertical = false;

            
            if (GetComponent<GridLayoutGroup>().spacing == Vector2.zero)
            {
                Vector2 spacingVector = new Vector2(spacing, 0);
                GetComponent<GridLayoutGroup>().spacing = spacingVector;
            }
            else
            {
                if (GetComponent<GridLayoutGroup>().spacing.x != 0)
                    spacing = GetComponent<GridLayoutGroup>().spacing.x;
            }

            GetComponent<GridLayoutGroup>().startAxis = GridLayoutGroup.Axis.Vertical;
            GetComponent<GridLayoutGroup>().constraint = GridLayoutGroup.Constraint.FixedRowCount;
            GetComponent<GridLayoutGroup>().constraintCount = 1;
            josefajackson = (elenagil + spacing) / 2;
        }
        else
        {
            transform.parent.GetComponent<ScrollRect>().horizontal = false;
            transform.parent.GetComponent<ScrollRect>().vertical = true;

            if (GetComponent<GridLayoutGroup>().spacing == Vector2.zero)
            {
                Vector2 spacingVector = new Vector2(0, spacing);
                GetComponent<GridLayoutGroup>().spacing = spacingVector;
            }
            else
            {
                if (GetComponent<GridLayoutGroup>().spacing.y != 0)
                    spacing = GetComponent<GridLayoutGroup>().spacing.y;
            }

            GetComponent<GridLayoutGroup>().startAxis = GridLayoutGroup.Axis.Horizontal;
            GetComponent<GridLayoutGroup>().constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            GetComponent<GridLayoutGroup>().constraintCount = 1;
            josefajackson = (miriamclements + spacing) / 2;
        }

        valeriewebber = new List<float>();
        albertamoyer = new List<GameObject>();

        
        foreach (Transform orawilcox in transform)
            albertamoyer.Add(orawilcox.gameObject);

        
        if (erikasavage)
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(albertamoyer.Count * elenagil + (albertamoyer.Count - 1) * spacing, miriamclements);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(GetComponent<RectTransform>().sizeDelta.x - 2 * spacing, GetComponent<RectTransform>().anchoredPosition.y);

            float terryrutherford = GetComponent<RectTransform>().sizeDelta.x / 2 - elenagil / 2;
            valeriewebber.Add(terryrutherford);

            
            albertamoyer[0].transform.localScale = new Vector3(amypoe, amypoe, 1);
			
            for (int i = 1; i < albertamoyer.Count; i++)
            {
                terryrutherford -= elenagil + spacing;
                valeriewebber.Add(terryrutherford);
				
                
                albertamoyer[i].transform.localScale = new Vector3(nellieadair, nellieadair, 1);
            }
        }
        else
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(elenagil, albertamoyer.Count * miriamclements + (albertamoyer.Count - 1) * spacing);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(GetComponent<RectTransform>().anchoredPosition.x, -(GetComponent<RectTransform>().sizeDelta.y - 2 * spacing));

            float terryrutherford = GetComponent<RectTransform>().sizeDelta.y / 2 - miriamclements / 2;
            valeriewebber.Add(terryrutherford);

            
            albertamoyer[0].transform.localScale = new Vector3(amypoe, amypoe, 1);
			
            for (int i = 1; i < albertamoyer.Count; i++)
            {
                terryrutherford -= miriamclements + spacing;
                valeriewebber.Add(terryrutherford);
				
                
                albertamoyer[i].transform.localScale = new Vector3(nellieadair, nellieadair, 1);
            }
        }

        jenniedonahue(gladysweller);

        chandralayton();
    }

 









private void jenniedonahue(int num)
    {
        int rosalynguerra = 0;
        if (valeriewebber.Count >= num)
        {
            rosalynguerra = valeriewebber.Count - 1;

        }
        else
        {
            rosalynguerra = num;
        }
        if (erikasavage)
        {
             
            shirleywaller = new Vector3(valeriewebber[rosalynguerra], 0, 0);
        }
        else
        {
            rosalynguerra = valeriewebber.Count - 1 - rosalynguerra;
            shirleywaller = new Vector3(0, valeriewebber[rosalynguerra], 0);
        }

        eulasparks = rosalynguerra;
        transform.localPosition = shirleywaller;
        vickiecoker = true;
    }

    private void chandralayton()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            byte[] loadPixels = new byte[helgacrowe * mariannemoss * 4];
            loadPixels = darcydeleon(bertiedelarosa + i.ToString());

            if (loadPixels != null)
            {
                Texture2D tex = new Texture2D(helgacrowe, mariannemoss, TextureFormat.RGBA32, false);
                tex.filterMode = FilterMode.Point;
                tex.wrapMode = TextureWrapMode.Clamp;
                tex.LoadRawTextureData(loadPixels);
                tex.Apply(false);

                transform.GetChild(i).GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0, 0, helgacrowe, mariannemoss), Vector2.zero, 100);
            }
        }
    }

    private byte[] darcydeleon(string key)
    {
#if UNITY_WEBGL
        string friedaweir = Application.persistentDataPath + "/Landscape" + key + ".sav";
        if (File.Exists(friedaweir))
        {
            return System.Convert.FromBase64String(File.ReadAllText(friedaweir));
        }
        else
        {
            return null;
        }
#else
        if (PlayerPrefs.HasKey(key))
        {
            return System.Convert.FromBase64String(PlayerPrefs.GetString(key));
        }
        else
        {
            return null;
        }
#endif
    }

    
    private void herminiagarza()
    {
        for (int i = 0; i < valeriewebber.Count; i++)
        {
            if (erikasavage)
            {
                if (transform.localPosition.x > valeriewebber[i] - josefajackson - 1 && transform.localPosition.x <= valeriewebber[i] + josefajackson)
                {
                    shirleywaller = new Vector3(valeriewebber[i], 0, 0);
                    vickiecoker = true;
                    eulasparks = i;
                    break;
                }
            }
            else
            {
                if (transform.localPosition.y > valeriewebber[i] - josefajackson - 1 && transform.localPosition.y <= valeriewebber[i] + josefajackson)
                {
                    shirleywaller = new Vector3(0, valeriewebber[i], 0);
                    vickiecoker = true;
                    eulasparks = albertamoyer.Count - i - 1;
                    break;
                }
            }
        }
    }

    private void maureenvalenzuela()
    {
        for (int i = 0; i < valeriewebber.Count; i++)
        {
            if (erikasavage)
            {
                if (transform.localPosition.x > valeriewebber[i] - josefajackson - 1 && transform.localPosition.x <= valeriewebber[i] + josefajackson)
                {
                    eulasparks = i;
                    break;
                }
            }
            else
            {
                if (transform.localPosition.y > valeriewebber[i] - josefajackson - 1 && transform.localPosition.y <= valeriewebber[i] + josefajackson)
                {
                    eulasparks = albertamoyer.Count - i - 1;
                    break;
                }
            }
        }
    }

    
    private IEnumerator chasityhatch()
    {
        yield return new WaitForSeconds(0.4f);
        nelliemeier = false;
    }

    public void nanettepainter()
    {
        if (erikasavage)
        {
            if (eulasparks > 0 && !nelliemeier)
            {
                
                nelliemeier = true;

                eulasparks -= 1;
                shirleywaller = new Vector3(valeriewebber[eulasparks], transform.localPosition.y, 0);
                vickiecoker = true;

                StartCoroutine(chasityhatch());
            }
        }
        else
        {
            if (eulasparks > 0 && !nelliemeier)
            {
                
                nelliemeier = true;
				
                eulasparks -= 1;
                shirleywaller = new Vector3(transform.localPosition.x, valeriewebber[albertamoyer.Count - eulasparks - 1], 0);
                vickiecoker = true;
				
                StartCoroutine(chasityhatch());
            }
        }
    }

    public void kelleypagan()
    {
        if (erikasavage)
        {
            if (eulasparks < valeriewebber.Count - 1 && !nelliemeier)
            {
                
                nelliemeier = true;

                eulasparks += 1;
                shirleywaller = new Vector3(valeriewebber[eulasparks], transform.localPosition.y, 0);
                vickiecoker = true;

                StartCoroutine(chasityhatch());
            }
        }
        else
        {
            if (eulasparks < albertamoyer.Count - 1 && !nelliemeier)
            {
                
                nelliemeier = true;
				
                eulasparks += 2;
                shirleywaller = new Vector3(transform.localPosition.x, valeriewebber[albertamoyer.Count - eulasparks], 0);
                vickiecoker = true;
				
                StartCoroutine(chasityhatch());
            }
        }
    }

    private void carissatipton(GameObject button)
    {
        if (!aracelicortez)
            return;
        Color c = button.GetComponent<Image>().color;
        c = new Color(1, 1, 1, 1);
        button.GetComponent<Image>().color = c;
        

        button.GetComponent<Button>().interactable = true;
    }

    private void joannavarela(GameObject button)
    {
        if (!aracelicortez)
            return;
        Color c = button.GetComponent<Image>().color;
        c = new Color(1, 1, 1, 0.3f);
        button.GetComponent<Image>().color = c;
        
		
        button.GetComponent<Button>().interactable = false;
    }

    private void LateUpdate()
    {
        
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButton(0)) && !nelliemeier)
        {
            maureenvalenzuela();
            shirleywaller = transform.localPosition;
        }

        
        if (erikasavage)
        {
            if (!vickiecoker && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.x) >= 0f && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.x) < 100f)
            {
                herminiagarza();
            }
            else
            {
                maureenvalenzuela();
            }
        }
        else
        {
            if (!vickiecoker && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.y) >= 0f && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.y) < 100f)
            {
                herminiagarza();
            }
            else
            {
                maureenvalenzuela();
            }
        }

        
        if (erikasavage)
        {
            if (eulasparks == 0)
            {
                float yvetteherbert = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x - josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;

                if (yvetteherbert <= nellieadair || yvetteherbert > amypoe)
                    yvetteherbert = nellieadair;

                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);

                albertamoyer[eulasparks + 1].transform.localScale = new Vector3(yvetteherbert, yvetteherbert, 1);
            }
            else if (eulasparks == albertamoyer.Count - 1)
            {
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float peggysanchez = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x + josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;

                if (peggysanchez <= nellieadair || peggysanchez > amypoe)
                    peggysanchez = nellieadair;

                albertamoyer[eulasparks - 1].transform.localScale = new Vector3(peggysanchez, peggysanchez, 1);
                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);
            }
            else
            {
                float yvetteherbert = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x - josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float peggysanchez = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] - transform.localPosition.x + josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;
				
                if (yvetteherbert <= nellieadair || yvetteherbert > amypoe)
                    yvetteherbert = nellieadair;

                if (peggysanchez <= nellieadair || peggysanchez > amypoe)
                    peggysanchez = nellieadair;

                albertamoyer[eulasparks - 1].transform.localScale = new Vector3(peggysanchez, peggysanchez, 1);
                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);
                albertamoyer[eulasparks + 1].transform.localScale = new Vector3(yvetteherbert, yvetteherbert, 1);
            }
        }
        else
        {
            if (eulasparks == 0)
            {
                float yvetteherbert = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y - josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;
				
                if (yvetteherbert <= nellieadair || yvetteherbert > amypoe)
                    yvetteherbert = nellieadair;

                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);
                albertamoyer[eulasparks + 1].transform.localScale = new Vector3(yvetteherbert, yvetteherbert, 1);
            }
            else if (eulasparks == albertamoyer.Count - 1)
            {
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float peggysanchez = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y + josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;
				
                if (peggysanchez <= nellieadair || peggysanchez > amypoe)
                    peggysanchez = nellieadair;

                albertamoyer[eulasparks - 1].transform.localScale = new Vector3(peggysanchez, peggysanchez, 1);
                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);
            }
            else
            {
                float yvetteherbert = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y - josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float lilianatyson = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);
                float peggysanchez = Mathf.Abs(Mathf.Abs(valeriewebber[eulasparks] + transform.localPosition.y + josefajackson * 2) * (amypoe - nellieadair) / Mathf.Abs(josefajackson * 2) - amypoe);

                if (lilianatyson <= nellieadair || lilianatyson > amypoe)
                    lilianatyson = nellieadair;
				
                if (yvetteherbert <= nellieadair || yvetteherbert > amypoe)
                    yvetteherbert = nellieadair;
				
                if (peggysanchez <= nellieadair || peggysanchez > amypoe)
                    peggysanchez = nellieadair;

                albertamoyer[eulasparks - 1].transform.localScale = new Vector3(peggysanchez, peggysanchez, 1);
                albertamoyer[eulasparks].transform.localScale = new Vector3(lilianatyson, lilianatyson, 1);
                albertamoyer[eulasparks + 1].transform.localScale = new Vector3(yvetteherbert, yvetteherbert, 1);
            }
        }

        
        if (vickiecoker)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, shirleywaller, deloressadler);

            if (Vector3.Distance(transform.localPosition, shirleywaller) < 1f)
            {
                transform.localPosition = shirleywaller;
                transform.parent.GetComponent<ScrollRect>().velocity = new Vector3(0, 0, 0);
                vickiecoker = false;

                for (int i = 0; i < albertamoyer.Count; i++)
                {
                    if (i != eulasparks)
                        albertamoyer[i].transform.localScale = new Vector3(nellieadair, nellieadair, 1);
                }

            }
        }

        if (erikasavage)
        {
            
            if (transform.localPosition.x > valeriewebber[valeriewebber.Count - 1] - spacing / 2)
            {
                carissatipton(floranewell);
            }
            else
            {
                joannavarela(floranewell);
            }

            if (transform.localPosition.x < valeriewebber[0] + spacing / 2)
            {
                carissatipton(priscillamyers);
            }
            else
            {
                joannavarela(priscillamyers);
            }
        }
        else
        {
            
            if (transform.localPosition.y > valeriewebber[valeriewebber.Count - 1] - spacing / 2)
            {
                carissatipton(priscillamyers);
            }
            else
            {
                joannavarela(priscillamyers);
            }
			
            if (transform.localPosition.y < valeriewebber[0] + spacing / 2)
            {
                carissatipton(floranewell);
            }
            else
            {
                joannavarela(floranewell);
            }
        }
    }


    string berylmallory = "fd6bfc309e94f6d4";
    int augustawhaley;

  

    private void LoadInterstitial()
    {
        MaxSdk.LoadInterstitial(berylmallory);
    }

    private void OnInterstitialLoadedEvent(string berylmallory, MaxSdkBase.AdInfo adInfo)
    {
        

        
        augustawhaley = 0;
    }

    private void OnInterstitialLoadFailedEvent(string berylmallory, MaxSdkBase.ErrorInfo errorInfo)
    {
        
        

        augustawhaley++;
        double retryDelay = System.Math.Pow(2, System.Math.Min(6, augustawhaley));

        Invoke("LoadInterstitial", (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string berylmallory, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialAdFailedToDisplayEvent(string berylmallory, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        
        LoadInterstitial();
    }

    private void OnInterstitialClickedEvent(string berylmallory, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialHiddenEvent(string berylmallory, MaxSdkBase.AdInfo adInfo)
    {
        
        LoadInterstitial();
    }

    public void freidalanders(int index)
    {
        denvergibson.Instance.ShowAdMob(); 
       
        PlayerPrefs.SetInt(bertiedelarosa, index);
        PlayerPrefs.Save();

        if (transform.GetChild(index).childCount > 0)
        {
            dudleypham.chasityneal = index;
        }
        else
        {
            dudleypham.chasityneal = -1;
        }

        dudleypham.katherynelder = bertiedelarosa + index.ToString();
        SceneManager.LoadScene("PaintScene");
    }
}
