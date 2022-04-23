using UnityEngine;
using System;
public interface ISelectable 
{
    Vector3 SelectableScale { get; }
    Rigidbody2D Rigidbody { get; }
    GameObject SelectableGameObject { get; }
    Action<ISelectable> SelectableAction { get; set; }
    Action<ISelectable> DeselectableAction { get; set; }
    Action<ISelectable> MouseDragAction { get; set; }
}
