using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class grantbarnhart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool lilliestover = false;
    [System.Serializable]
    public class jonmoon : UnityEvent { }
    [SerializeField]
    private jonmoon myOwnEvent = new grantwinn();
    public jonmoon onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, marjoriegibbons = 1f;
    private Vector3 startPosition, mistycowan;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (lilliestover)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (lilliestover)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator carolebass()
    {
        yield return estherstallings(transform, transform.localPosition, mistycowan, marjoriegibbons);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float darlafigueroa = 1.0f / value;
        float orawilcox = 0.0f;
        while (orawilcox < 1.0)
        {
            orawilcox += Time.deltaTime * darlafigueroa;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, orawilcox));
            yield return null;
        }

        thisTransform.localPosition = mistycowan;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        mistycowan = EPos;

        marjoriegibbons = MTime;

        StartCoroutine(carolebass());
    }
}
