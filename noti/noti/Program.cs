using System;

namespace notificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notificaciones");
            Console.WriteLine("-------------------------------------------------");

            NotificacionEmail emailNotif = new NotificacionEmail();
            emailNotif.Correo = "al8817515@gmail.com";

            NotificacionWhatsapp whatsappNotif = new NotificacionWhatsapp();
            whatsappNotif.Cel = "+502 41317980";

            NotificacionSMS smsNotif = new NotificacionSMS();
            smsNotif.Celw = "+502 56259772";

           
            emailNotif.Notifica("Verifica tu correo ");
            whatsappNotif.Notifica("Hola soy tu tia Gylda");
            smsNotif.Notifica("Gyt Codigo de seguritada es : ********* \n si desea ver el codigo necesita depositar Q30");
        }
    }

    public interface INotificable
    {
        
        void Notifica(string mensaje);
    }

    public class NotificacionEmail : INotificable
    {
      
        public string Correo { get; set; }

      
        public void Notifica(string mensaje)
        {
            Console.WriteLine($"notificación GMAIL: {Correo}");
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }

    
    public class NotificacionWhatsapp : INotificable
    {
   
        public string Cel { get; set; }

      
        public void Notifica(string mensaje)
        {
            Console.WriteLine($"notificación de WhatsApp: {Cel}");
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }


    public class NotificacionSMS : INotificable
    {
        
        public string Celw { get; set; }

        
        public void Notifica(string mensaje)
        {
            Console.WriteLine($"notificación por SMS : {Celw}");
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }
}