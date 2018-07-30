using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject
{
    [MetadataType(typeof(Botmetadata))]
    public partial class Bottom
    {
    }

    public class Botmetadata
    {
        public int BottomID { get; set; }
        [DisplayName("NAME")]
        public string BName { get; set; }
        [DisplayName("TYPE")]
        public string BType { get; set; }
        [DisplayName("COLOR")]
        public string BColor { get; set; }
        [DisplayName("SEASON")]
        public string BSeason { get; set; }
        [DisplayName("OCCASION")]
        public string BOccasion { get; set; }
        [DisplayName("PHOTO")]
        public string BPhoto { get; set; }
    }
   }