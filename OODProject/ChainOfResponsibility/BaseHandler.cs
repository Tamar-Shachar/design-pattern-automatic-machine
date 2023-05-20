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
            //Application.Restart();
            Form form1 = Application.OpenForms["Form1"];
            form1.Controls.RemoveByKey("okButton");
            form1.Controls.RemoveByKey("amount");
            form1.Controls.RemoveByKey("label");
            form1.Controls.RemoveByKey("label2");
            form1.Controls["StartShoppingBtn"].Show();
            return null;
        }
    }

    public IHandler SetNext(IHandler handler)
    {
        this.nextHandler = handler;
        return handler;
    }
}
