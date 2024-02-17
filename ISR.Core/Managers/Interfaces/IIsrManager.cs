using ISR.Core.Entities;

namespace ISR.Core.Managers.Interfaces;

public interface IIsrManager{
    Isr GetIsr (Person person);

}