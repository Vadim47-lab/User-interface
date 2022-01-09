using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Assets.Script.Extesions;

public class ScreenshotView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _date;

    private Transform _draginParent;
    private Transform _previousParent;

    internal void Init(Transform draginParent)
    {
        _draginParent = draginParent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _previousParent = transform.parent;
        transform.parent = _draginParent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.parent = _previousParent;
        var container = EventSystem.current.GetFirstComponentUnderPoianter<DropContainer>(eventData);

        if (container != null)
        {
            transform.parent = container.Container;
        }
        else
        {
            transform.parent = _previousParent;
        }
    }

    public void Render(Screenshot screenshot)
    {
        _image.sprite = screenshot.Image;
        _date.text = screenshot.CreationTime.ToString();
    }
}