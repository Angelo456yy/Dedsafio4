using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noti
{
    
    
        public interface INotificable
        {
           
            void Notifica(string mensaje);
        }

      
        public class NotificacionEmail : INotificable
        {
  
            public string DireccionCorreo { get; set; }

        
            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando notificación por email a: {DireccionCorreo}");
                Console.WriteLine($"Mensaje: {mensaje}");
            }
        }

   
        public class NotificacionWhatsapp : INotificable
        {
          
            public string NumeroTelefono { get; set; }

            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando notificación por WhatsApp al número: {NumeroTelefono}");
                Console.WriteLine($"Mensaje: {mensaje}");
            }
        }

      
        public class NotificacionSMS : INotificable
        {
            
            public string NumeroTelefono { get; set; }

            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando notificación por SMS al número: {NumeroTelefono}");
                Console.WriteLine($"Mensaje: {mensaje}");
            }
        
    }
}
