using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _text;

    public void OnButtonClick()
    {
        Destroy(_text);
    }
}