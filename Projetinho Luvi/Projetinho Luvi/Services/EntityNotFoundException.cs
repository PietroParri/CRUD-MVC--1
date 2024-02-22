using System;

namespace Projetinho_Luvi
{
    public class EntityNotFoundException : Exception
    {
        public string LogMessage { get; set; }

        public EntityNotFoundException(string message, string logMessage)
            : base(message)
        {
            this.LogMessage = logMessage;
        }
    }
}
