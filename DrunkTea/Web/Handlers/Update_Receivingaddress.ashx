<%@ WebHandler Language="C#" Class="Update_Receivingaddress" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Update_Receivingaddress : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
           context.Response.ContentType = "text/plain";
        Receivingaddress recAddress = new Receivingaddress();
        recAddress.Rname = context.Request.Params["Rname"];
        recAddress.RecId = Convert.ToInt32(context.Request.Params["RecId"]);
        recAddress.Phone = context.Request.Params["Phone"];
        recAddress.Address = context.Request.Params["Address"];
        bool boo = new ReceivingaddressManager().Update(recAddress);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(bool));
        dt.WriteObject(context.Response.OutputStream, boo);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}