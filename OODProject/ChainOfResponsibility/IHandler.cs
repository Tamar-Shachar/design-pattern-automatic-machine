using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal interface IHandler
{
    IHandler SetNext(IHandler handler);
    IItem Handel(IItem item);
}
