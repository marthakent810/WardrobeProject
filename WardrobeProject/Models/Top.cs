using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject
{
    [MetadataType(typeof(Topmetadata))]
    public partial class Top
    {
    }

    public class Topmetadata
    {
        public int TopId { get; set; }
        [DisplayName("NAME")]
        public string TName { get; set; }
        [DisplayName("TYPE")]
        public string TType { get; set; }
        [DisplayName("COLOR")]
        public string TColor { get; set; }
        [DisplayName("SEASON")]
        public string TSeason { get; set; }
        [DisplayName("OCCASION")]
        public string TOccasion { get; set; }
        [DisplayName("PHOTO")]
        public string TPhoto { get; set; }

    }
}
