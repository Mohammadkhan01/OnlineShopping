using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for ControlFinder
/// </summary>
public class ControlFinder<T> where T: Control
{
    private readonly List<T> foundControl = new List<T>();

    public IEnumerable <T> FoundControl
    {
        get { return foundControl; }
    }

    public void FindChildControlRecursive(Control control)
    {
        foreach(Control childControl in control.Controls )
        {
            if(childControl .GetType ()==typeof (T))
                foundControl .Add ((T) childControl) ;
            else{
                FindChildControlRecursive (childControl );
            }
        }
    }
}