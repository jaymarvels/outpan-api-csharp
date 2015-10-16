using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OutPanApiGet
{

    public class OutpanApiAllModel
    {
        public string gtin { get; set; }
        public string outpan_url { get; set; }
        public string name { get; set; }
        public Attributes attributes { get; set; }
        public IList<string> images { get; set; }
        public IList<string> videos { get; set; }
    }

    public class OutpanApiNameModel
    {
        public string gtin { get; set; }
        public string outpan_url { get; set; }
        public string name { get; set; }
    }

    public class OutpanApiAttributesModel
    {
        public string gtin { get; set; }
        public string outpan_url { get; set; }
        public Attributes attributes { get; set; }
    }

    public class OutpanApiVideosModel
    {
        public string gtin { get; set; }
        public string outpan_url { get; set; }
        public IList<string> videos { get; set; }
    }

    public class OutpanApiImageModel
    {
        public string gtin { get; set; }
        public string outpan_url { get; set; }
        public List<string> images { get; set; }
    }

    [Serializable]
    public class Attributes
    {
        [JsonProperty(PropertyName = "Aspect Ratio")]
        public string AspectRatio { get; set; }
        public string Audio { get; set; }
        public string Brand { get; set; }
        public string Brightness { get; set; }

        [JsonProperty(PropertyName = "Contrast Ratio")]
        public string ContrastRatio { get; set; }
        public string Dimensions { get; set; }

        [JsonProperty(PropertyName = "Display Technology")]
        public string DisplayTechnology { get; set; }

        [JsonProperty(PropertyName = "Light Source Type")]
        public string LightSourceType { get; set; }

        [JsonProperty(PropertyName = "Maximum Resolution")]
        public string MaximumResolution { get; set; }
        public string Memory { get; set; }

        [JsonProperty(PropertyName = "Native Resolution")]
        public string NativeResolution { get; set; }

        [JsonProperty(PropertyName = "Power Consumption")]
        public string PowerConsumption { get; set; }

        [JsonProperty(PropertyName = "Power Supply")]
        public string PowerSupply { get; set; }

        [JsonProperty(PropertyName = "Projection Method")]
        public string ProjectionMethod { get; set; }

        [JsonProperty(PropertyName = "Remote Control")]
        public string RemoteControl { get; set; }
        public string Security { get; set; }

        [JsonProperty(PropertyName = "Throw Ratio")]
        public string ThrowRatio { get; set; }
        public string Uniformity { get; set; }
        public string Warranty { get; set; }
        public string Zoom { get; set; }
    }
}
