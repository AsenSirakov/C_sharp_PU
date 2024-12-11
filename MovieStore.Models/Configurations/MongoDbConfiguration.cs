using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Configurations
{
    public class MongoDbConfiguration
    {
        public string ConnetctionString { get; set; }
       
        public string DatabaseName { get; set; }
    }
}
