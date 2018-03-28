<%@ WebHandler Language="C#" Class="GetList_Orders" %>

using System;
using System.Web;
using Model;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using BLL;
public class GetList_Orders : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        List<Orders> lst = new OrderManager().GetList(Uid);
        DataContractJsonSerializer dr = new DataContractJsonSerializer(typeof(List<Orders>));
        dr.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}