<%@ WebHandler Language="C#" Class="UpdateCart_ByUidandTid" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
public class UpdateCart_ByUidandTid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        string Tid = context.Request.Params["Tid"];
        string Number = context.Request.Params["Number"];
        bool boo = new CartManager().UpdateCart_ByUidandTid(Uid, Tid, Number);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}