using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Feature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("x-vetro")]
        public XVetro XVetro { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<double>>>Coordinates { get; set; }

        //[JsonProperty("coordinates")]
        //public double[] coordinatesSimple { get; set; }
    }

    public class Properties
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Site Name")]
        public string Name { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Glide Reference")]
        public string GlideReference { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Note")]
        public string Note { get; set; }

        [JsonProperty("PCP ID")]
        public string PcpId { get; set; }

        [JsonProperty("Attr ID")]
        public long AttrId { get; set; }
    }

    public class XVetro
    {
        [JsonProperty("vetro_id")]
        public string VetroId { get; set; }

        [JsonProperty("layer_id")]
        public long LayerId { get; set; }

        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        [JsonProperty("feature_id")]
        public long FeatureId { get; set; }
    }
}

