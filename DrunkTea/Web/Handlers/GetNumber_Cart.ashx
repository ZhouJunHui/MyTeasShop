<%@ WebHandler Language="C#" Class="GetNumber_Cart" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
public class GetNumber_Cart : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        int number = new CartManager().GetNumber_Cart(Uid);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(int));
        ds.WriteObject(context.Response.OutputStream, number);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}