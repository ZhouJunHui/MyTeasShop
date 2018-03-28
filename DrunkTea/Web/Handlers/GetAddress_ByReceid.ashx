<%@ WebHandler Language="C#" Class="GetAddress_ByReceid" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetAddress_ByReceid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string id = context.Request.Params["RecId"];
        Receivingaddress  model = new ReceivingaddressManager().GetAddress_ByReceid(id);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(Receivingaddress));
        dt.WriteObject(context.Response.OutputStream, model);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}