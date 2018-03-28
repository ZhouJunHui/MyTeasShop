<%@ WebHandler Language="C#" Class="Add_Receivingaddress" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Add_Receivingaddress : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        Receivingaddress recAddress = new Receivingaddress();
        recAddress.Rname = context.Request.Params["Rname"];
        recAddress.Uid = Convert.ToInt32(context.Request.Params["Uid"]);
        recAddress.Phone = context.Request.Params["Phone"];
        recAddress.Address = context.Request.Params["Address"];
        bool boo = new ReceivingaddressManager().Add(recAddress);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(bool));
        dt.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}