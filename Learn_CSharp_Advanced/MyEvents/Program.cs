using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Harry Potter and the magical stone" };
            var encoder = new VideoEncoder();

            var mailService = new MailService();
            var smsService = new SMSService();
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += smsService.OnVideoEncoded;

            encoder.Encode(video);
        }
    }
}
