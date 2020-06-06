using System.Collections.Generic;

namespace NacosACMDemo
{
    /*
     {
	"ConnectionStrings": {
		"Default": "Server=127.0.0.1;Port=3306;Database=demo;User Id=root;Password=123456;"
	},
	"version": "����version",
	"AppSettings": {
		"Str": "val",
		"num": 1,
		"arr": [1, 2, 3],
		"subobj": {
			"a": "b"
		}
	}
}
         */
    public class AppSettings
    {
        public string Str { get; set; }

        public int Num { get; set; }

        public List<int> Arr { get; set; }

        public SubObj SubObj { get; set; }
    }

    public class SubObj
    {
        public string a { get; set; }
    }
}
