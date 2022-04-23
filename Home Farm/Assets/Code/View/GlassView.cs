using System;
using UnityEngine;

public class GlassView : MonoBehaviour, IContainer, ISelectable
{
    [SerializeField] private float _timeWatering;
    [SerializeField] private float _timePlant;
    [SerializeField] private float _size;
    [SerializeField] private bool _free;

    private Action _timeWateringAction;
    private Action _timePlantAction;
    private Action<ISelectable> _selectableAction;
    private Action<ISelectable> _mouseDragAction;
    private Action<ISelectable> _deselectableAction;
    private Vector3 _selectableScale;
    private Rigidbody2D _rigidbody;

    public Vector3 SelectableScale => _selectableScale;
    public Action<ISelectable> MouseDragAction { get => _mouseDragAction; set => _mouseDragAction = value; }
    public Action<ISelectable> SelectableAction { get => _selectableAction; set => _selectableAction = value; }
    public Action<ISelectable> DeselectableAction { get => _deselectableAction; set => _deselectableAction = value; }
    public Action TimeWateringAction => _timeWateringAction;
    public Action TimePlantAction => _timePlantAction;
    public Rigidbody2D Rigidbody => _rigidbody;
    public GameObject SelectableGameObject => gameObject;
    public float TimeWatering { get => _timeWatering; set => _timeWatering = value; }
    public float TimePlant { get => _timePlant; set => _timePlant = value; }
    public float Size => _size;
    public bool Free { get => _free; set => _free = value; }



    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _selectableScale = transform.localScale;
    }

    private void OnMouseEnter()
    {
        _selectableAction?.Invoke(this);
    }

    private void OnMouseExit()
    {
        _deselectableAction?.Invoke(this);
    }

    private void OnMouseDrag()
    {
        _mouseDragAction?.Invoke(this);
    }
}
