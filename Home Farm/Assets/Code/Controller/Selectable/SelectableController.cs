public class SelectableController 
{
    private SelectableModel _selectableModel;
    
    public SelectableController(SelectableModel selectableModel)
    {
        _selectableModel = selectableModel;
    }

    public void SubscribeOnSelected() // пригодится при добавлении новых объектов из магазина
    {
        foreach(var selected in _selectableModel.ListSelectable)
        {
            selected.SelectableAction = null;
            selected.SelectableAction += OnSelect;

            selected.DeselectableAction = null;
            selected.DeselectableAction += OnDeselect;
        }
    }

    private void OnSelect(ISelectable selectable)
    {
        var oldScale = selectable.SelectableScale;
        var newScale = oldScale + oldScale * 0.1f;

        selectable.SelectableGameObject.transform.localScale = newScale;
    }

    private void OnDeselect(ISelectable selectable)
    {
        selectable.SelectableGameObject.transform.localScale = selectable.SelectableScale;
    }
}
