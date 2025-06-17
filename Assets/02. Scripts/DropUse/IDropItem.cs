using System;
using UnityEngine;

public interface IDropItem
{
    void Grab(Transform GrabPos);
    void Use();
    void Drop();
}