using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal abstract class BaseHandler : IHandler
{
    private IHandler nextHandler;
    public virtual Task<IItem> Handel(IItem item)
    {
        if (this.Handel != null)
        {
            return this.nextHandler.Handel(item);
        }
        else
        {
            Form form1 = Application.OpenForms["Form1"];
            //form1.Controls.ContainsKey("jj").TryFormat()
            return null;
        }
    }

    public IHandler SetNext(IHandler handler)
    {
        this.nextHandler = handler;
        return handler;
    }
}
