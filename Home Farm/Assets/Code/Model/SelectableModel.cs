using System.Collections.Generic;

public class SelectableModel
{
    public List<ISelectable> ListSelectable;

    public SelectableModel()
    {
        ListSelectable = new List<ISelectable>();
    }
}
