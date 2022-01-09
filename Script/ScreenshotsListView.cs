using System;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotsListView : MonoBehaviour
{
    [SerializeField] private ScreenshotView _template;
    [SerializeField] private Transform _container;
    [SerializeField] private Sprite _deafultSprite;
    [SerializeField] private Transform _draginParent;

    private void Awake()
    {
        Render(new List<Screenshot>()
        {
            new Screenshot(_deafultSprite, DateTime.Now),
            new Screenshot(_deafultSprite, DateTime.Now),
            new Screenshot(_deafultSprite, DateTime.Now),
        });
    }

    private void Render(IEnumerable<Screenshot> screenshots)
    {
        foreach (var screenshot in screenshots)
        {
            var view = Instantiate(_template, _container) as ScreenshotView;
            view.Init(_draginParent);
            view.Render(screenshot);
        }
    }
}