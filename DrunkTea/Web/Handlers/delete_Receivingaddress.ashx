<%@ WebHandler Language="C#" Class="delete_Receivingaddress" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class delete_Receivingaddress : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
         context.Response.ContentType = "text/plain";
         string recId = context.Request.Params["recId"];
        bool boo = new ReceivingaddressManager().Delete(recId);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(bool));
        dt.WriteObject(context.Response.OutputStream, boo);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}