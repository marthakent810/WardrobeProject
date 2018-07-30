using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject
{
    [MetadataType(typeof(Accmetadata))]
    public partial class Accessory
    {
    }

    public class Accmetadata
    {
        public int AccessoryID { get; set; }
        [DisplayName("NAME")]
        public string AName { get; set; }
        [DisplayName("TYPE")]
        public string AType { get; set; }
        [DisplayName("COLOR")]
        public string AColor { get; set; }
        [DisplayName("SEASON")]
        public string ASeason { get; set; }
        [DisplayName("OCCASION")]
        public string AOccasion { get; set; }
        [DisplayName("PHOTO")]
        public string APhoto { get; set; }
    }
}
