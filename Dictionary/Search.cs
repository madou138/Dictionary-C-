using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{

    public class SearchWords
    {
        public Wc_Link wc_link { get; set; }
        [JsonProperty(PropertyName = "meta")]
        public List<Meta> Metas { get; set; }
        public Hwi hwi { get; set; }
        public string fl { get; set; }
        public Def1[] def { get; set; }
        public Uro[] uros { get; set; }
        public string[][] et { get; set; }
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        [JsonProperty(PropertyName="ld_link")]
        public Ld_Link LdLlink { get; set; }
        public Suppl suppl { get; set; }
        public string[] shortdef { get; set; }
    }

    public class Wc_Link
    {
        public string link_hw { get; set; }
    }

    public class Meta
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string uuid { get; set; }
        public string sort { get; set; }
        public string update { get; set; }
        public string editdate { get; set; }
        [JsonProperty(PropertyName = "release")]
        public string Release { get; set; }
        public string src { get; set; }
        public string section { get; set; }
        public string[] stems { get; set; }
        public bool offensive { get; set; }
    }

    public class Hwi
    {
        public string hw { get; set; }
        public Pr[] prs { get; set; }
    }

    public class Pr
    {
        public string mw { get; set; }
        public Sound sound { get; set; }
    }

    public class Sound
    {
        public string audio { get; set; }
        public string _ref { get; set; }
        public string stat { get; set; }
    }

    public class Ld_Link
    {
        public string link_hw { get; set; }
        public string link_fl { get; set; }
    }

    public class Suppl
    {
        public Example[] examples { get; set; }
        public Ldq ldq { get; set; }
    }

    public class Ldq
    {
        public string ldhw { get; set; }
        public string fl { get; set; }
        public Def[] def { get; set; }
    }

    public class Def
    {
        public string[] sls { get; set; }
        public object[][][] sseq { get; set; }
    }

    public class Example
    {
        public string t { get; set; }
    }

    public class Def1
    {
        public object[][][] sseq { get; set; }
    }

    public class Uro
    {
        public string ure { get; set; }
        public string fl { get; set; }
    }

}
