<%@ WebHandler Language="C#" Class="GetList_Receivingaddress" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetList_Receivingaddress : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        List<Receivingaddress> list = new ReceivingaddressManager().GetList_ByUid(Uid);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(List<Receivingaddress>));
        dt.WriteObject(context.Response.OutputStream, list);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}