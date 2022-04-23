using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private GlassView[] _glassView;


    #region Controllers

    private AddSelectebleObjectInModelController _addSelectebleObjectInModelController;
    private ChangePositionController _changePositionController;
    private SelectableController _selectableController;


    #endregion

    #region Model

    private SelectableModel _selectableModel;

    #endregion

    private void Awake()
    {
        InitializeModels();
        InitializeAwakeControllers();
    }

    private void Start()
    {
        foreach(var o in _glassView)
        {
            _selectableModel.ListSelectable.Add(o); // Временно, пока не сделано сохранение и загрузка объектов на сцену
        }
       
        StartSubscribe();
    }

    private void InitializeModels()
    {
        _selectableModel = new SelectableModel();
    }

    private void InitializeAwakeControllers()
    {
        _selectableController = new SelectableController(_selectableModel);
        _changePositionController = new ChangePositionController(_selectableModel);
    }

    private void StartSubscribe()
    {
        _selectableController.SubscribeOnSelected();
        _changePositionController.Subscribe();
    }

    private void Update()
    {
    }
}
