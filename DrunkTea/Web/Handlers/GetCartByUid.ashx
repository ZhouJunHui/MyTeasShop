<%@ WebHandler Language="C#" Class="GetCartByUid" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetCartByUid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        List<Teas> lst = new CartManager().GetListByUid(Uid);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(List<Teas>));
        ds.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}