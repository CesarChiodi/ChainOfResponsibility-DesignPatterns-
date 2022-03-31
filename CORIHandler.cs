using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_DesignPatterns_
{
    // A interface Handler declara um método para construir a cadeia de handlers.
    // Também declara um método para executar uma requisição.

    public interface CORIHandler    //COR = Chain of Responsibility
    {
        CORIHandler SetNext(CORIHandler handler);
        object Handle(object request);
    }


    // O comportamento de encadeamento padrão pode ser implementado dentro da BASE de uma HANDLERclass.
    abstract class AbstractHandler : CORIHandler
    {
        private CORIHandler _nextHandler;
        public CORIHandler SetNext(CORIHandler handler)
        {
            this._nextHandler = handler;

            // Retornar um Handler daqui nos permitirá vincular Handlers de uma maneira conveniente
            // Por Exemplo: monkey.SetNext(squirrel).SetNext(dog);
            
            return handler;
        }
        public virtual object Handle(object request)    // Pode ser substituído por qualquer classe que o herde
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
