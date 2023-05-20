using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal abstract class BaseHandler : IHandler
{
    private IHandler nextHandler;
    public virtual Task<IItem> Handel(IItem item)
    {
        if (this.nextHandler != null)
        {
            return this.nextHandler.Handel(item);
        }
        else
        {
            Application.Restart();
            /*Form form1 = Application.OpenForms["Form1"];
            foreach (Control ctrl in form1.Controls)
            {
                if (!ctrl.Name.Equals("StartShoppingBtn")
                    && !ctrl.Name.Equals("Title")) {
                    form1.Controls.Remove(ctrl);
                }
            }
            form1.Controls["StartShoppingBtn"].Show();*/
            return null;
        }
    }
    public IHandler SetNext(IHandler handler)
    {
        this.nextHandler = handler;
        return handler;
    }
}
