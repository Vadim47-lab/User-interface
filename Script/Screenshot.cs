using System;
using UnityEngine;

[Serializable]
public class Screenshot
{
    private readonly Sprite _image;
    private readonly DateTime _creationTime;

    public Screenshot(Sprite image, DateTime creationtime)
    {
        _image = image;
        _creationTime = creationtime;
    }

    public Sprite Image => _image;
    public DateTime CreationTime => _creationTime;
}