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
            return null;
        }
    }
    public IHandler SetNext(IHandler handler)
    {
        this.nextHandler = handler;
        return handler;
    }
}
