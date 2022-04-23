using UnityEngine;

public class ChangePositionController
{
    private SelectableModel _selectableModel;

    public ChangePositionController(SelectableModel selectableModel)
    {
        _selectableModel = selectableModel;
    }

    public void Subscribe()
    {
        foreach(var selected in _selectableModel.ListSelectable)
        {
            selected.MouseDragAction += MouseDrag;
        }
    }

    private void MouseDrag(ISelectable selectable)
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var position = new Vector3(mousePosition.x, mousePosition.y, 0);

        selectable.Rigidbody.velocity = Vector3.zero;
        selectable.SelectableGameObject.transform.position = position;
    }
}
