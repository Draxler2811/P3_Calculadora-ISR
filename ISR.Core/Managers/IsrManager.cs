using ISR.Core.Entities;
using ISR.Core.Managers.Interfaces;
using ISR.Core.Services.Interfaces;

namespace ISR.Core.Managers;

public class IsrManager : IIsrManager{
    private readonly IIsrService _service;

    public IsrManager(IIsrService service){
        _service = service;
    }

    public Isr GetIsr(Person person){
        return _service.ProcessIsr(person);
    }
}