using ISR.Core.Entities;

namespace ISR.Core.Services.Interfaces;

public interface IIsrService{
    Isr ProcessIsr (Person person); 
}