using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coder.ServerAgent
{
    static class ServerAgent
    {
        //AzureToolkit
        //Http:POST://string json newloader,region,email,pin
          //access loader_blob(region)
            //GET check if email not exists in metadata then return fail
            //GET last page, increment,
            // POST new page details and pin offset record, update metadata 
            //     return success;
        

      //Http://PUT:json changepin,region,email,oldpin,newpin

      
            //access loader_blob(region)
            //GET check if email and pin correct - return false
            //PUT change pin offset record 
            //     return success;
        

        // Http://PUT:changeemail,region,email,newemail,pin)
        
            //access loader_blob(region)
            //GET check if email and pin correct - return false
            //PUT delete and change email metadata
            //     return success;
        

    }
}
