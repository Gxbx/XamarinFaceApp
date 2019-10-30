using System.Collections.Generic;

namespace XamarinApp.Models
{
    public class ResponseModel
    {
        public string faceId { get; set; }
        public FaceAttributes faceAttributes { get; set; }
    }


    public class FaceAttributes
    {
        public double smile { get; set; }
        public string gender { get; set; }
        public double age { get; set; }
        public string glasses { get; set; }

    }

}
