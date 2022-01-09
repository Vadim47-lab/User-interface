using UnityEngine;

public class Toggle : MonoBehaviour
{
    [SerializeField] private GameObject Text;

    public void OnToggleChanged(bool state)
    {
        Text.SetActive(state);
    }
}