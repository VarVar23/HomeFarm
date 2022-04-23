public class AddSelectebleObjectInModelController
{
    private SelectableModel _selectableModel;
    private ISelectable[] _selectables;

    public AddSelectebleObjectInModelController(SelectableModel selectableModel, ISelectable[] selectables)
    {
        _selectableModel = selectableModel;
        _selectables = selectables;
    }

    public void AddSelectablesOnScene()
    {
        for (int i = 0; i < _selectables.Length; i++)
        {
            _selectableModel.ListSelectable.Add(_selectables[i]);
        }
    }

    public void AddNewSelectable(ISelectable selectable) => _selectableModel.ListSelectable.Add(selectable);

}
