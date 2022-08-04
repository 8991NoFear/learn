using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /*
     * 
     * What?
     * 
     * Why?
     * +, Interface and Testability [v]
     * 
     * +, Interface and Extensibility [v]
     * 
     * +, Interface and Inheritance [x]
     * Interface is used to build more loosely coupling application, enhance testability
     * and extensibility but have nothing to do with Inheritance
     * 
     * +, Interface and Polymorphism [v]
     */
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegistrationNotificationChannel(new MailService());
            encoder.RegistrationNotificationChannel(new SMSService());


            var video = new Video() { VideoName = "Harry Potter and the magical stone" };
            encoder.Encode(video);
        }
    }
}
