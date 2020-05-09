using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class MyService : IMyService
    {
     public string Getdata()
      {
      return "PRITESHKUMAR";
      }
    }
}
