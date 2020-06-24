using Core.Events;

namespace Core
{
    public interface IRoutine
    {
        void Execute();

        event SomeEventHandler SomeEvent;
    }
}