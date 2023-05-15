using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal interface IHandler
{
    IHandler SetNext(IHandler handler);
    Task<IItem> Handel(IItem item);
}
