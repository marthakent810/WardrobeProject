using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject
{
    [MetadataType(typeof(Shoemetadata))]
    public partial class Sho
    {
    }

    public class Shoemetadata
    {
        public int ShoeID { get; set; }
        [DisplayName("NAME")]
        public string SName { get; set; }
        [DisplayName("TYPE")]
        public string SType { get; set; }
        [DisplayName("COLOR")]
        public string SColor { get; set; }
        [DisplayName("SEASON")]
        public string SSeason { get; set; }
        [DisplayName("OCCASION")]
        public string SOccasion { get; set; }
        [DisplayName("PHOTO")]
        public string SPhoto { get; set; }
    }
}


