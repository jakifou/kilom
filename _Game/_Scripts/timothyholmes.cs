using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class bennyhorne : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool altacorrea = false;
    [System.Serializable]
    public class morrisspaulding : UnityEvent { }
    [SerializeField]
    private morrisspaulding myOwnEvent = new grantwinn();
    public morrisspaulding onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, jasminevaughan = 1f;
    private Vector3 startPosition, leahclements;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (altacorrea)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (altacorrea)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator rondasteele()
    {
        yield return estherstallings(transform, transform.localPosition, leahclements, jasminevaughan);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float mollielevin = 1.0f / value;
        float ursularobles = 0.0f;
        while (ursularobles < 1.0)
        {
            ursularobles += Time.deltaTime * mollielevin;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, ursularobles));
            yield return null;
        }

        thisTransform.localPosition = leahclements;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        leahclements = EPos;

        jasminevaughan = MTime;

        StartCoroutine(rondasteele());
    }
}
